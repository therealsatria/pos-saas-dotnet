using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a permission that can be assigned to roles
    
    public class Permission : BaseEntity
    {
        
        /// Initializes a new instance of the Permission class
        
        public Permission()
        {
            RolePermissions = new HashSet<RolePermission>();
        }

        
        /// Gets or sets the permission name
        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        
        /// Gets or sets the permission description
        
        [Required]
        [MaxLength(512)]
        public string Description { get; set; } = string.Empty;

        
        /// Gets or sets the collection of role permissions
        
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
