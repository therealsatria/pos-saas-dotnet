using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a tax rate that can be applied to sales
    /// </summary>
    public class Tax : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Tax class
        /// </summary>
        public Tax()
        {
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the tax name
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the tax rate
        /// </summary>
        [Required]
        [Range(0, 1)]
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
