using System;

namespace Infrastructures.Entities
{
    public class Category : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
    }
}
