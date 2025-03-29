using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents a many-to-many relationship between users and roles
    /// </summary>
    public class UserRole : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the UserRole class
        /// </summary>
        public UserRole()
        {
        }

        /// <summary>
        /// Gets or sets the user ID
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the role ID
        /// </summary>
        [Required]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Gets or sets the associated user
        /// </summary>
        [NotNull]
        public virtual User? User { get; set; }

        /// <summary>
        /// Gets or sets the associated role
        /// </summary>
        [NotNull]
        public virtual Role? Role { get; set; }
    }
}
