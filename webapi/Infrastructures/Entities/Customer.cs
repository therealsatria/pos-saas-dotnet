using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a customer in the system
    
    public class Customer : BaseEntity
    {
        
        /// Initializes a new instance of the Customer class
        
        public Customer()
        {
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the customer name
        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        
        /// Gets or sets the customer phone number
        
        [Required]
        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        
        /// Gets or sets the customer email address
        
        [Required]
        [EmailAddress]
        [MaxLength(256)]
        public string Email { get; set; } = string.Empty;

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        
        /// Gets or sets the associated loyalty points
        
        public virtual LoyaltyPoints? LoyaltyPoints { get; set; }
    }
}
