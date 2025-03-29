using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents an audit log entry for system actions
    /// </summary>
    public class AuditLog : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the AuditLog class
        /// </summary>
        public AuditLog()
        {
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the user ID who performed the action
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Gets or sets the action performed
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Gets or sets the associated user
        /// </summary>
        public virtual User? User { get; set; }
    }
}
