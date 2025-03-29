using System.Collections.Generic;

namespace Core.Entities
{
    public class Role : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public string Permissions { get; set; }  // JSONB storage
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
