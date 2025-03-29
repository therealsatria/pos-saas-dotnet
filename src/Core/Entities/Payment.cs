using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents a payment for a sales transaction
    /// </summary>
    public class Payment : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Payment class
        /// </summary>
        public Payment()
        {
        }

        /// <summary>
        /// Gets or sets the sale ID
        /// </summary>
        [Required]
        public Guid SaleId { get; set; }

        /// <summary>
        /// Gets or sets the payment method
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Method { get; set; } = string.Empty;  // cash/card/ewallet

        /// <summary>
        /// Gets or sets the payment amount
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the payment transaction ID
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the associated sale
        /// </summary>
        [NotNull]
        public virtual Sale? Sale { get; set; }
    }
}
