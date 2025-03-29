using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents a many-to-many relationship between roles and permissions
    /// </summary>
    public class RolePermission : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the RolePermission class
        /// </summary>
        public RolePermission()
        {
        }

        /// <summary>
        /// Gets or sets the role ID
        /// </summary>
        [Required]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Gets or sets the permission ID
        /// </summary>
        [Required]
        public Guid PermissionId { get; set; }

        /// <summary>
        /// Gets or sets the associated role
        /// </summary>
        [NotNull]
        public virtual Role? Role { get; set; }

        /// <summary>
        /// Gets or sets the associated permission
        /// </summary>
        [NotNull]
        public virtual Permission? Permission { get; set; }
    }
}
