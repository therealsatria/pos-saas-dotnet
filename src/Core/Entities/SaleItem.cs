using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents an item within a sales transaction
    /// </summary>
    public class SaleItem : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the SaleItem class
        /// </summary>
        public SaleItem()
        {
        }

        /// <summary>
        /// Gets or sets the sale ID
        /// </summary>
        [Required]
        public Guid SaleId { get; set; }

        /// <summary>
        /// Gets or sets the product ID
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity sold
        /// </summary>
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price at time of sale
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the associated sale
        /// </summary>
        [NotNull]
        public virtual Sale? Sale { get; set; }

        /// <summary>
        /// Gets or sets the associated product
        /// </summary>
        [NotNull]
        public virtual Product? Product { get; set; }

        /// <summary>
        /// Gets the total price for this sale item (quantity * unit price)
        /// </summary>
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
