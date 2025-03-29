using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    public class UserRole : BaseEntity
    {
        public UserRole()
        {
        }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        [NotNull]
        public virtual User? User { get; set; }

        [NotNull]
        public virtual Role? Role { get; set; }
    }
}
