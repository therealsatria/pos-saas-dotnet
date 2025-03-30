using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a subscription plan available for tenants
    
    public class SubscriptionPlan : BaseEntity
    {
        
        /// Initializes a new instance of the SubscriptionPlan class
        
        public SubscriptionPlan()
        {
            Subscriptions = new HashSet<Subscription>();
        }

        
        /// Gets or sets the plan name
        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        
        /// Gets or sets the plan price
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        
        /// Gets or sets the plan features (stored as JSON)
        
        [Required]
        public string Features { get; set; } = string.Empty;

        
        /// Gets or sets the collection of subscriptions
        
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
