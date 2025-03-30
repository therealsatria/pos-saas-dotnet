using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a tenant in the multi-tenant system
    
    public class Tenant : BaseEntity
    {
        
        /// Initializes a new instance of the Tenant class
        
        public Tenant()
        {
            Subscriptions = new HashSet<Subscription>();
            Users = new HashSet<User>();
            Products = new HashSet<Product>();
        }

        
        /// Gets or sets the tenant name
        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        
        /// Gets or sets the tenant subdomain
        
        [Required]
        [MaxLength(128)]
        [RegularExpression(@"^[a-z0-9-]+$", ErrorMessage = "Subdomain can only contain lowercase letters, numbers, and hyphens")]
        public string Subdomain { get; set; } = string.Empty;

        
        /// Gets or sets the tenant's database connection string
        
        [Required]
        [MaxLength(512)]
        public string ConnectionString { get; set; } = string.Empty;

        
        /// Gets or sets the collection of subscriptions
        
        public virtual ICollection<Subscription> Subscriptions { get; set; }

        
        /// Gets or sets the collection of users
        
        public virtual ICollection<User> Users { get; set; }

        
        /// Gets or sets the collection of products
        
        public virtual ICollection<Product> Products { get; set; }
    }
}
