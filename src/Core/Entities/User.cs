using System.Collections.Generic;

namespace Core.Entities
{
    public class User : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
