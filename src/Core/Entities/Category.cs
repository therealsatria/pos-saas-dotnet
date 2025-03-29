using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents a product category in the system
    /// </summary>
    public class Category : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Category class
        /// </summary>
        public Category()
        {
            ChildCategories = new HashSet<Category>();
            ProductCategories = new HashSet<ProductCategory>();
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the category name
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the parent category ID
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Gets or sets the parent category
        /// </summary>
        public virtual Category? ParentCategory { get; set; }

        /// <summary>
        /// Gets or sets the collection of child categories
        /// </summary>
        public virtual ICollection<Category> ChildCategories { get; set; }

        /// <summary>
        /// Gets or sets the collection of product categories
        /// </summary>
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
