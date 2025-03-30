using System;

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
    }
}
