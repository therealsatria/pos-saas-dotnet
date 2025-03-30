using System;

namespace Infrastructures.Entities
{
    public class InventoryLog : BaseEntity
    {
        public Guid InventoryId { get; set; }
        public int Quantity { get; set; }
        public string ActionType { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
