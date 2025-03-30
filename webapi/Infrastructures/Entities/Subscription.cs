using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a tenant's subscription to a plan
    
    public class Subscription : BaseEntity
    {
        
        /// Initializes a new instance of the Subscription class
        
        public Subscription()
        {
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the plan ID
        
        [Required]
        public Guid PlanId { get; set; }

        
        /// Gets or sets the subscription status
        
        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = string.Empty;

        
        /// Gets or sets the subscription start date
        
        [Required]
        public DateTime StartDate { get; set; }

        
        /// Gets or sets the subscription end date
        
        public DateTime? EndDate { get; set; }

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        
        /// Gets or sets the associated subscription plan
        
        [NotNull]
        public virtual SubscriptionPlan? Plan { get; set; }
    }
}
