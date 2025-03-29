using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents a user role with associated permissions
    /// </summary>
    public class Role : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Role class
        /// </summary>
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the role name
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the role permissions (stored as JSON)
        /// </summary>
        [Required]
        public string Permissions { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Gets or sets the collection of user roles
        /// </summary>
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
