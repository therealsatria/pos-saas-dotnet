using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a tenant's subscription to a plan
    /// </summary>
    public class Subscription : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Subscription class
        /// </summary>
        public Subscription()
        {
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the plan ID
        /// </summary>
        [Required]
        public Guid PlanId { get; set; }

        /// <summary>
        /// Gets or sets the subscription status
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the subscription start date
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the subscription end date
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Gets or sets the associated subscription plan
        /// </summary>
        [NotNull]
        public virtual SubscriptionPlan? Plan { get; set; }
    }
}
