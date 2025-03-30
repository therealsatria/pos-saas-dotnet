using System;

namespace Infrastructures.Entities
{
    public class Supplier : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
    }
}
