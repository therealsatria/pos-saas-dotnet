using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents a discount that can be applied to sales
    /// </summary>
    public class Discount : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Discount class
        /// </summary>
        public Discount()
        {
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the discount code
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the discount value
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the discount type (percentage/fixed)
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
