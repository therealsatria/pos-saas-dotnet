using System;
using System.Collections.Generic;

namespace Infrastructures.Entities
{
    public class Category : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public Category ParentCategory { get; set; }
        public ICollection<Category> ChildCategories { get; set; }
    }
}
