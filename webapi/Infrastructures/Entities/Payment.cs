using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a payment for a sales transaction
    
    public class Payment : BaseEntity
    {
        
        /// Initializes a new instance of the Payment class
        
        public Payment()
        {
        }

        
        /// Gets or sets the sale ID
        
        [Required]
        public Guid SaleId { get; set; }

        
        /// Gets or sets the payment method
        
        [Required]
        [MaxLength(50)]
        public string Method { get; set; } = string.Empty;  // cash/card/ewallet

        
        /// Gets or sets the payment amount
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        
        /// Gets or sets the payment transaction ID
        
        [Required]
        [MaxLength(256)]
        public string TransactionId { get; set; } = string.Empty;

        
        /// Gets or sets the associated sale
        
        [NotNull]
        public virtual Sale? Sale { get; set; }
    }
}
