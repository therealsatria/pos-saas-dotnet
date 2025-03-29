using System.Collections.Generic;

namespace Core.Entities
{
    public class Category : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public Category ParentCategory { get; set; }
        public ICollection<Category> ChildCategories { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
