using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents a subscription plan available for tenants
    /// </summary>
    public class SubscriptionPlan : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionPlan class
        /// </summary>
        public SubscriptionPlan()
        {
            Subscriptions = new HashSet<Subscription>();
        }

        /// <summary>
        /// Gets or sets the plan name
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the plan price
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the plan features (stored as JSON)
        /// </summary>
        [Required]
        public string Features { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of subscriptions
        /// </summary>
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
