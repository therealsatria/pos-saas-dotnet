using System;

namespace Infrastructures.Entities
{
    public class InventoryLog : BaseEntity
    {
        public Guid InventoryId { get; set; }
        public int Quantity { get; set; }
        public string ActionType { get; set; } // restock/sale/adjustment
        public DateTime CreatedAt { get; set; }
        
        // Navigation properties
        public Inventory Inventory { get; set; }
    }
}
