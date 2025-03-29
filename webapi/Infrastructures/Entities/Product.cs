using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a product in the system
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Product class
        /// </summary>
        public Product()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the product SKU
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string SKU { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the product name
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the product price
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the supplier ID
        /// </summary>
        public Guid? SupplierId { get; set; }

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Gets or sets the associated supplier
        /// </summary>
        public virtual Supplier? Supplier { get; set; }

        /// <summary>
        /// Gets or sets the collection of product categories
        /// </summary>
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }

        /// <summary>
        /// Gets or sets the inventory information
        /// </summary>
        public virtual Inventory? Inventory { get; set; }
    }
}
