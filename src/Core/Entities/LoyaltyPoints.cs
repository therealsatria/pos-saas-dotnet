using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents a customer's loyalty points balance
    /// </summary>
    public class LoyaltyPoints : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the LoyaltyPoints class
        /// </summary>
        public LoyaltyPoints()
        {
        }

        /// <summary>
        /// Gets or sets the customer ID
        /// </summary>
        [Required]
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the points balance
        /// </summary>
        [Required]
        [Range(0, int.MaxValue)]
        public int Balance { get; set; }

        /// <summary>
        /// Gets or sets the associated customer
        /// </summary>
        [NotNull]
        public virtual Customer? Customer { get; set; }
    }
}
