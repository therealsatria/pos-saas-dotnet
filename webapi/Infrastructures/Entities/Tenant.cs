using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a tenant in the multi-tenant system
    /// </summary>
    public class Tenant : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Tenant class
        /// </summary>
        public Tenant()
        {
            Subscriptions = new HashSet<Subscription>();
            Users = new HashSet<User>();
            Products = new HashSet<Product>();
        }

        /// <summary>
        /// Gets or sets the tenant name
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the tenant subdomain
        /// </summary>
        [Required]
        [MaxLength(128)]
        [RegularExpression(@"^[a-z0-9-]+$", ErrorMessage = "Subdomain can only contain lowercase letters, numbers, and hyphens")]
        public string Subdomain { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the tenant's database connection string
        /// </summary>
        [Required]
        [MaxLength(512)]
        public string ConnectionString { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of subscriptions
        /// </summary>
        public virtual ICollection<Subscription> Subscriptions { get; set; }

        /// <summary>
        /// Gets or sets the collection of users
        /// </summary>
        public virtual ICollection<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the collection of products
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }
}
