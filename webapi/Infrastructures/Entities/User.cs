using System;

namespace pos_saas.Entities
{
    public class User : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogin { get; set; }
        public string Status { get; set; }
    }
}
