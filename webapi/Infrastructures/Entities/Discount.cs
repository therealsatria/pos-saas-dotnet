using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a discount that can be applied to sales
    
    public class Discount : BaseEntity
    {
        
        /// Initializes a new instance of the Discount class
        
        public Discount()
        {
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the discount code
        
        [Required]
        [MaxLength(50)]
        public string Code { get; set; } = string.Empty;

        
        /// Gets or sets the discount value
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Value { get; set; }

        
        /// Gets or sets the discount type (percentage/fixed)
        
        [Required]
        [MaxLength(20)]
        public string Type { get; set; } = string.Empty;

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
