using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents an item within a sales transaction
    
    public class SaleItem : BaseEntity
    {
        
        /// Initializes a new instance of the SaleItem class
        
        public SaleItem()
        {
        }

        
        /// Gets or sets the sale ID
        
        [Required]
        public Guid SaleId { get; set; }

        
        /// Gets or sets the product ID
        
        [Required]
        public Guid ProductId { get; set; }

        
        /// Gets or sets the quantity sold
        
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        
        /// Gets or sets the unit price at time of sale
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal UnitPrice { get; set; }

        
        /// Gets or sets the associated sale
        
        [NotNull]
        public virtual Sale? Sale { get; set; }

        
        /// Gets or sets the associated product
        
        [NotNull]
        public virtual Product? Product { get; set; }

        
        /// Gets the total price for this sale item (quantity * unit price)
        
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
