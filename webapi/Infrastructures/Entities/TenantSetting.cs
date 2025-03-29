using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a tenant-specific setting
    /// </summary>
    public class TenantSetting : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the TenantSetting class
        /// </summary>
        public TenantSetting()
        {
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the setting key
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the setting value
        /// </summary>
        [Required]
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
