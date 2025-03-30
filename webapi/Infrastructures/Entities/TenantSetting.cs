using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a tenant-specific setting
    
    public class TenantSetting : BaseEntity
    {
        
        /// Initializes a new instance of the TenantSetting class
        
        public TenantSetting()
        {
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the setting key
        
        [Required]
        [MaxLength(256)]
        public string Key { get; set; } = string.Empty;

        
        /// Gets or sets the setting value
        
        [Required]
        public string Value { get; set; } = string.Empty;

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
