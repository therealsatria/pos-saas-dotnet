using System;

namespace Infrastructures.Entities
{
    public class Tax : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
    }
}
