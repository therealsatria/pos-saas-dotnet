using System;

namespace Infrastructures.Entities
{
    public class Customer : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public LoyaltyPoint LoyaltyPoints { get; set; }
    }
}
