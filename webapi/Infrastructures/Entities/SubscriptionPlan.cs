using System;
using System.Collections.Generic;

namespace pos_saas.Entities
{
    public class SubscriptionPlan : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Dictionary<string, object> Features { get; set; }
    }
}
