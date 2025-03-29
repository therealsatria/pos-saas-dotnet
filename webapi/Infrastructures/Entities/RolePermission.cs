using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    public class RolePermission : BaseEntity
    {
        public RolePermission()
        {
        }

        [Required]
        public Guid RoleId { get; set; }

        [Required]
        public Guid PermissionId { get; set; }

        [NotNull]
        public virtual Role? Role { get; set; }

        [NotNull]
        public virtual Permission? Permission { get; set; }
    }
}
