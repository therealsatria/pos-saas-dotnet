using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents a sales transaction in the system
    /// </summary>
    public class Sale : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Sale class
        /// </summary>
        public Sale()
        {
            SaleItems = new HashSet<SaleItem>();
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the user ID who made the sale
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the total amount of the sale
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Gets or sets the associated user
        /// </summary>
        [NotNull]
        public virtual User? User { get; set; }

        /// <summary>
        /// Gets or sets the collection of sale items
        /// </summary>
        public virtual ICollection<SaleItem> SaleItems { get; set; }

        /// <summary>
        /// Gets or sets the associated payment
        /// </summary>
        public virtual Payment? Payment { get; set; }
    }
}
