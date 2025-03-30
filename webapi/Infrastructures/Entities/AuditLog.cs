using System;

namespace Infrastructures.Entities
{
    public class AuditLog : BaseEntity
    {
        public Guid TenantId { get; set; }
        public Guid UserId { get; set; }
        public string Action { get; set; }
        public DateTime CreatedAt { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public User User { get; set; }
    }
}
