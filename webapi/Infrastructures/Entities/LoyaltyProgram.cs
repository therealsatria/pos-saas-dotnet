using System;
using System.Collections.Generic;

namespace Infrastructures.Entities
{
    public class LoyaltyProgram : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public decimal PointsRate { get; set; } // Points per currency
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public ICollection<LoyaltyPoint> LoyaltyPoints { get; set; }
    }
}
