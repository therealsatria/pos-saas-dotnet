using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Infrastructures.Entities
{
    public class SubscriptionPlan : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public JsonDocument Features { get; set; }
        
        // Navigation properties
        public ICollection<Subscription> Subscriptions { get; set; }
    }
}
