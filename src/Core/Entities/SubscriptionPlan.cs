using System.Collections.Generic;

namespace Core.Entities
{
    public class SubscriptionPlan : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Features { get; set; }  // JSONB storage
        
        // Navigation properties
        public ICollection<Subscription> Subscriptions { get; set; }
    }
}
