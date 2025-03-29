using System.Collections.Generic;

namespace Core.Entities
{
    public class LoyaltyProgram : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public decimal PointsRate { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public ICollection<LoyaltyPoints> LoyaltyPoints { get; set; }
    }
}
