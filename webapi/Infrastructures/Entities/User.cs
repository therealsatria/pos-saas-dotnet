using System;
using System.Collections.Generic;

namespace Infrastructures.Entities
{
    public class User : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Status { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public ICollection<AuditLog> AuditLogs { get; set; }
    }
}
