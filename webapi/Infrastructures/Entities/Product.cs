using System;
using System.Collections.Generic;

namespace Infrastructures.Entities
{
    public class Product : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal CostPrice { get; set; }
        public string UnitOfMeasure { get; set; }
        public Guid? SupplierId { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public Supplier Supplier { get; set; }
        public Inventory Inventory { get; set; }
    }
}
