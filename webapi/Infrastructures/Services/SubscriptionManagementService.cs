using Infrastructures.Entities;
using Infrastructures.Repositories;
using Infrastructures.Exceptions;
using Infrastructures.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Services
{
    public class SubscriptionManagementService : GenericService<Subscription>
    {
        private readonly IGenericRepository<Subscription> _subscriptionRepository;
        private readonly IGenericRepository<Tenant> _tenantRepository;
        private readonly IGenericRepository<SubscriptionPlan> _planRepository;

        public SubscriptionManagementService(
            IGenericRepository<Subscription> subscriptionRepository,
            IGenericRepository<Tenant> tenantRepository,
            IGenericRepository<SubscriptionPlan> planRepository)
            : base(subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository ?? throw new ArgumentNullException(nameof(subscriptionRepository));
            _tenantRepository = tenantRepository ?? throw new ArgumentNullException(nameof(tenantRepository));
            _planRepository = planRepository ?? throw new ArgumentNullException(nameof(planRepository));
        }

        // public override async Task<IEnumerable<Subscription>> GetAllAsync()
        // {
        //     var subscriptions = await _subscriptionRepository.GetQueryable()
        //         //.Include(s => s.Plan)
        //         //.Include(s => s.Tenant)
        //         .ToListAsync();
        //     return subscriptions;
        // }
        public async Task<Subscription> GetByTenantIdAsync(Guid tenantId)
        {
            // Get subscription with related Plan and Tenant data
            var subscription = await _subscriptionRepository.GetQueryable()
                .Include(s => s.Plan)
                .Include(s => s.Tenant)
                .FirstOrDefaultAsync(s => s.TenantId == tenantId);

            if (subscription == null)
                throw new NotFoundException("Subscription not found for this tenant");

            return subscription;
        }
        public override async Task<Subscription> GetByIdAsync(Guid id)
        {
            var subscription = await _subscriptionRepository.GetQueryable()
                .Include(s => s.Plan)
                .Include(s => s.Tenant)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (subscription == null)
                throw new NotFoundException("Subscription not found");

            return subscription;
        }
        public async Task<Subscription> CreateAsync(SubscriptionCreateRequest request)
        {
            if (request == null)
                throw new ValidationException("Request cannot be null");

            // Verify tenant exists
            var tenant = await _tenantRepository.GetQueryable()
                .FirstOrDefaultAsync(t => t.Id == request.TenantId);
            if (tenant == null)
                throw new ValidationException("Tenant not found");

            // Verify plan exists
            var plan = await _planRepository.GetQueryable()
                .FirstOrDefaultAsync(p => p.Id == request.PlanId);
            if (plan == null)
                throw new ValidationException("Subscription plan not found");

            var existingSubscription = await _subscriptionRepository.GetQueryable()
                .FirstOrDefaultAsync(s => s.TenantId == request.TenantId && s.PlanId == request.PlanId);

            if (existingSubscription != null)
                throw new ValidationException("Subscription already exists for this tenant and plan");

            var subscription = new Subscription
            {
                TenantId = tenant.Id,
                PlanId = plan.Id,
                Status = "Active",
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddMonths(request.DurationInMonths)
            };

            await _subscriptionRepository.AddAsync(subscription);
            return subscription;
        }

        public async Task<Subscription> UpdateAsync(Guid id, SubscriptionUpdateRequest request)
        {
            if (request == null)
                throw new ValidationException("Request cannot be null");

            var subscription = await _subscriptionRepository.GetQueryable()
                .FirstOrDefaultAsync(s => s.Id == id);

            if (subscription == null)
                throw new NotFoundException("Subscription not found");

            if (request.PlanId.HasValue && request.PlanId != subscription.PlanId)
            {
                var plan = await _planRepository.GetQueryable()
                    .FirstOrDefaultAsync(p => p.Id == request.PlanId);
                if (plan == null)
                    throw new ValidationException("Subscription plan not found");

                var existingSubscription = await _subscriptionRepository.GetQueryable()
                    .FirstOrDefaultAsync(s => s.TenantId == subscription.TenantId && 
                                            s.PlanId == request.PlanId && 
                                            s.Id != subscription.Id);

                if (existingSubscription != null)
                    throw new ValidationException("Subscription already exists for this tenant and plan");

                subscription.PlanId = plan.Id;
            }

            if (!string.IsNullOrEmpty(request.Status))
            {
                subscription.Status = request.Status;
            }

            if (request.DurationInMonths > 0)
            {
                subscription.EndDate = subscription.StartDate.AddMonths(request.DurationInMonths);
            }

            await _subscriptionRepository.UpdateAsync(subscription);
            return subscription;
        }
    }
}