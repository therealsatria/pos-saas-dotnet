using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a product in the system
    
    public class Product : BaseEntity
    {
        
        /// Initializes a new instance of the Product class
        
        public Product()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the product SKU
        
        [Required]
        [MaxLength(50)]
        public string SKU { get; set; } = string.Empty;

        
        /// Gets or sets the product name
        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        
        /// Gets or sets the product price
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        
        /// Gets or sets the supplier ID
        
        public Guid? SupplierId { get; set; }

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        
        /// Gets or sets the associated supplier
        
        public virtual Supplier? Supplier { get; set; }

        
        /// Gets or sets the collection of product categories
        
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }

        
        /// Gets or sets the inventory information
        
        public virtual Inventory? Inventory { get; set; }
    }
}
