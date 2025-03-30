using System;

namespace Infrastructures.Entities
{
    public class Inventory : BaseEntity
    {
        public Guid TenantId { get; set; }
        public Guid ProductId { get; set; }
        public int Stock { get; set; }
        public string Location { get; set; }
    }
}
