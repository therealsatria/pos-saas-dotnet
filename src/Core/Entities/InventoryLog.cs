namespace Core.Entities
{
    public class InventoryLog : BaseEntity
    {
        public Guid InventoryId { get; set; }
        public int Quantity { get; set; }
        public string ActionType { get; set; }  // restock/sale/adjustment
        
        // Navigation properties
        public Inventory Inventory { get; set; }
    }
}
