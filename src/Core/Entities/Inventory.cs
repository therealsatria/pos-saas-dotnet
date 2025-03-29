using System.Collections.Generic;

namespace Core.Entities
{
    public class Inventory : BaseEntity
    {
        public Guid TenantId { get; set; }
        public Guid ProductId { get; set; }
        public int Stock { get; set; }
        public string Location { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public Product Product { get; set; }
        public ICollection<InventoryLog> InventoryLogs { get; set; }
    }
}
