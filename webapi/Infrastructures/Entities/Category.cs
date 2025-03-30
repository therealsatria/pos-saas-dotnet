using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a product category in the system
    
    public class Category : BaseEntity
    {
        
        /// Initializes a new instance of the Category class
        
        public Category()
        {
            ChildCategories = new HashSet<Category>();
            ProductCategories = new HashSet<ProductCategory>();
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the category name
        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        
        /// Gets or sets the parent category ID
        
        public Guid? ParentId { get; set; }

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        
        /// Gets or sets the parent category
        
        public virtual Category? ParentCategory { get; set; }

        
        /// Gets or sets the collection of child categories
        
        public virtual ICollection<Category> ChildCategories { get; set; }

        
        /// Gets or sets the collection of product categories
        
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
