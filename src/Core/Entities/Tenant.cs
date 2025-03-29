using System.Collections.Generic;

namespace Core.Entities
{
    public class Tenant : BaseEntity
    {
        public string Name { get; set; }
        public string Subdomain { get; set; }
        public string ConnectionString { get; set; }
        
        // Navigation properties
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
