using System;

namespace Infrastructures.Entities
{
    public class Subscription : BaseEntity
    {
        public Guid TenantId { get; set; }
        public Guid PlanId { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public SubscriptionPlan Plan { get; set; }
    }
}
