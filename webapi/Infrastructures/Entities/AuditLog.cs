using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    public class AuditLog : BaseEntity
    {
        public AuditLog()
        {
        }

        [Required]
        public Guid TenantId { get; set; }

        public Guid? UserId { get; set; }

        [Required]
        [MaxLength(256)]
        public string Action { get; set; } = string.Empty;

        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        public virtual User? User { get; set; }
    }
}
