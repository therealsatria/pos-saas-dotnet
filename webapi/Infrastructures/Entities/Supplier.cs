using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a supplier of products
    /// </summary>
    public class Supplier : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Supplier class
        /// </summary>
        public Supplier()
        {
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the supplier name
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the supplier contact information
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Contact { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
