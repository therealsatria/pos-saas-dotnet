using System.Collections.Generic;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public Inventory Inventory { get; set; }
    }
}
