using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
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
            RolePermissions = new HashSet<RolePermission>();
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
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Gets or sets the collection of user roles
        /// </summary>
        public virtual ICollection<UserRole> UserRoles { get; set; }

        /// <summary>
        /// Gets or sets the collection of role permissions
        /// </summary>
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
