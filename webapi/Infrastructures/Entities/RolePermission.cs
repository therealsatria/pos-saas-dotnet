using System;

namespace Infrastructures.Entities
{
    public class RolePermission : BaseEntity
    {
        public Guid RoleId { get; set; }
        public Guid PermissionId { get; set; }
        
        // Navigation properties
        public Role Role { get; set; }
        public Permission Permission { get; set; }
    }
} 