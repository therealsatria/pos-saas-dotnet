using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents a permission that can be assigned to roles
    /// </summary>
    public class Permission : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Permission class
        /// </summary>
        public Permission()
        {
            RolePermissions = new HashSet<RolePermission>();
        }

        /// <summary>
        /// Gets or sets the permission name
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the permission description
        /// </summary>
        [Required]
        [MaxLength(512)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of role permissions
        /// </summary>
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
