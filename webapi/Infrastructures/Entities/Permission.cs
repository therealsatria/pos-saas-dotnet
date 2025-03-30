using System;
using System.Collections.Generic;

namespace Infrastructures.Entities
{
    public class Permission : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TenantId { get; set; }
        
        // Navigation properties
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
