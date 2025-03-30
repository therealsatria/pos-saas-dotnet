using System;

namespace Infrastructures.Entities
{
    public class Discount : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Code { get; set; }
        public decimal Value { get; set; }
        public string Type { get; set; } // percentage/fixed
        
        // Navigation properties
        public Tenant Tenant { get; set; }
    }
}
