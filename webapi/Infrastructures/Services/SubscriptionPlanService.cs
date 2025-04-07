using Infrastructures.Entities;
using Infrastructures.Repositories;
using Infrastructures.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Infrastructures.DTOs;

namespace Infrastructures.Services
{
    public class SubscriptionPlanService : GenericService<SubscriptionPlan>
    {
        private readonly IGenericRepository<SubscriptionPlan> _subscriptionPlanRepository;

        public SubscriptionPlanService(IGenericRepository<SubscriptionPlan> subscriptionPlanRepository)
            : base(subscriptionPlanRepository)
        {
            _subscriptionPlanRepository = subscriptionPlanRepository ?? throw new ArgumentNullException(nameof(subscriptionPlanRepository));
        }
        public override async Task<IEnumerable<SubscriptionPlan>> GetAllAsync()
        {
            var subscriptionPlans = await _subscriptionPlanRepository.GetQueryable()
                .ToListAsync();

            return subscriptionPlans;
        }
        public override async Task<SubscriptionPlan> GetByIdAsync(Guid id)
        {
            var subscriptionPlan = await _subscriptionPlanRepository.GetQueryable()
                .FirstOrDefaultAsync(sp => sp.Id == id);

            if (subscriptionPlan == null)
                throw new NotFoundException("Subscription plan not found");

            return subscriptionPlan;
        }
        public async Task<SubscriptionPlan> CreateAsync(SubscriptionPlanCreateRequest request)
        {
            if (request == null)
                throw new ValidationException("Request cannot be null");

            var existingSubscriptionPlan = await _subscriptionPlanRepository.GetQueryable()
                .FirstOrDefaultAsync(sp => sp.Name == request.Name);

            if (existingSubscriptionPlan != null)
                throw new ValidationException("Subscription plan with this name already exists");

            var subscriptionPlan = new SubscriptionPlan
            {
                Name = request.Name,
                Price = request.Price,
                Features = JsonDocument.Parse(request.Features)
            };

            await _subscriptionPlanRepository.AddAsync(subscriptionPlan);
            return subscriptionPlan;
        }
        public async Task<SubscriptionPlan> UpdateAsync(Guid id, SubscriptionPlanUpdateRequest request)
        {
            if (request == null)
                throw new ValidationException("Request cannot be null");

            var existingSubscriptionPlan = await _subscriptionPlanRepository.GetQueryable()
                .FirstOrDefaultAsync(sp => sp.Id == id);

            if (existingSubscriptionPlan == null)
                throw new NotFoundException("Subscription plan not found");     

            existingSubscriptionPlan.Name = request.Name;
            existingSubscriptionPlan.Price = request.Price ?? existingSubscriptionPlan.Price;
            existingSubscriptionPlan.Features = JsonDocument.Parse(request.Features) ?? existingSubscriptionPlan.Features;

            await _subscriptionPlanRepository.UpdateAsync(existingSubscriptionPlan);
            return existingSubscriptionPlan;
        }
    }
}