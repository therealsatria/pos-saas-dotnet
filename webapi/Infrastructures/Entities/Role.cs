using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Infrastructures.Entities
{
    public class Role : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public JsonDocument Permissions { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
