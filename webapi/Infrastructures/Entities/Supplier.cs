using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a supplier of products
    
    public class Supplier : BaseEntity
    {
        
        /// Initializes a new instance of the Supplier class
        
        public Supplier()
        {
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the supplier name
        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        
        /// Gets or sets the supplier contact information
        
        [Required]
        [MaxLength(256)]
        public string Contact { get; set; } = string.Empty;

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
