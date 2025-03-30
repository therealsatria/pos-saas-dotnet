using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a many-to-many relationship between products and categories
    
    public class ProductCategory : BaseEntity
    {
        
        /// Initializes a new instance of the ProductCategory class
        
        public ProductCategory()
        {
        }

        
        /// Gets or sets the product ID
        
        [Required]
        public Guid ProductId { get; set; }

        
        /// Gets or sets the category ID
        
        [Required]
        public Guid CategoryId { get; set; }

        
        /// Gets or sets the associated product
        
        [NotNull]
        public virtual Product? Product { get; set; }

        
        /// Gets or sets the associated category
        
        [NotNull]
        public virtual Category? Category { get; set; }
    }
}
