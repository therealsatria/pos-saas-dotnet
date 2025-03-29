using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a many-to-many relationship between products and categories
    /// </summary>
    public class ProductCategory : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the ProductCategory class
        /// </summary>
        public ProductCategory()
        {
        }

        /// <summary>
        /// Gets or sets the product ID
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the category ID
        /// </summary>
        [Required]
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the associated product
        /// </summary>
        [NotNull]
        public virtual Product? Product { get; set; }

        /// <summary>
        /// Gets or sets the associated category
        /// </summary>
        [NotNull]
        public virtual Category? Category { get; set; }
    }
}
