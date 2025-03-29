using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a loyalty program configuration
    /// </summary>
    public class LoyaltyProgram : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the LoyaltyProgram class
        /// </summary>
        public LoyaltyProgram()
        {
            LoyaltyPoints = new HashSet<LoyaltyPoints>();
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the program name
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the points rate (points per currency unit)
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal PointsRate { get; set; }

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Gets or sets the collection of loyalty points
        /// </summary>
        public virtual ICollection<LoyaltyPoints> LoyaltyPoints { get; set; }
    }
}
