using Infrastructures.Entities;
using Infrastructures.Repositories;
using Infrastructures.Exceptions;
using Infrastructures.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Services
{
    public class TenantService : GenericService<Tenant>
    {
        private readonly IGenericRepository<Tenant> _tenantRepository;

        public TenantService(IGenericRepository<Tenant> tenantRepository)
            : base(tenantRepository)
        {
            _tenantRepository = tenantRepository ?? throw new ArgumentNullException(nameof(tenantRepository));
        }
        public override async Task<IEnumerable<Tenant>> GetAllAsync()
        {
            var tenants = await _tenantRepository.GetQueryable()
                .ToListAsync();

            return tenants; 
        }
        public override async Task<Tenant> GetByIdAsync(Guid id)
        {
            var tenant = await _tenantRepository.GetQueryable()
                .FirstOrDefaultAsync(t => t.Id == id);  

            if (tenant == null)
                throw new NotFoundException("Tenant not found");

            return tenant;
        }
        public async Task<Tenant> CreateAsync(TenantCreateRequest request)
        {
            if (request == null)
                throw new ValidationException("Request cannot be null");

            var existingTenant = await _tenantRepository.GetQueryable()
                .FirstOrDefaultAsync(t => t.Subdomain == request.Subdomain);

            if (existingTenant != null)
                throw new ValidationException("Tenant with this subdomain already exists");

            var tenant = new Tenant
            {
                Name = request.Name,
                Subdomain = request.Subdomain
            };

            await _tenantRepository.AddAsync(tenant);
            return tenant;  
        }
        public async Task<Tenant> UpdateAsync(Guid id, TenantUpdateRequest request)
        {
            if (request == null)
                throw new ValidationException("Request cannot be null");    

            var existingTenant = await _tenantRepository.GetQueryable()
                .FirstOrDefaultAsync(t => t.Id == id);

            if (existingTenant == null)
                throw new NotFoundException("Tenant not found");        

            existingTenant.Name = request.Name;
            existingTenant.Subdomain = request.Subdomain;

            await _tenantRepository.UpdateAsync(existingTenant);
            return existingTenant;
        }
        public async Task<Tenant> DeleteAsync(Guid id)
        {
            var tenant = await GetByIdAsync(id);
            await _tenantRepository.DeleteAsync(tenant.Id);
            return tenant;
        }   

        public async Task<Tenant> SoftDeleteAsync(Guid id)
        {
            var tenant = await GetByIdAsync(id);
            
            tenant.IsDeleted = true;
            
            await _tenantRepository.UpdateAsync(tenant);
            return tenant;
        }
    }
}