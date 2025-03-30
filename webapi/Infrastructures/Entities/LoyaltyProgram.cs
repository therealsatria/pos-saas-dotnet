using System;

namespace Infrastructures.Entities
{
    public class LoyaltyProgram : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public decimal PointsRate { get; set; }
    }
}
