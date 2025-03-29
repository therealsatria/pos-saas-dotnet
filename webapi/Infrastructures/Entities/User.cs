using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a user in the system
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the User class
        /// </summary>
        public User()
        {
            UserRoles = new HashSet<UserRole>();
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the user's email address
        /// </summary>
        [Required]
        [EmailAddress]
        [MaxLength(256)]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the password hash
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string PasswordHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Gets or sets the collection of user roles
        /// </summary>
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
