using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Inventory
{
    public class InventoryUpdateRequest
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be non-negative")]
        public int Quantity { get; set; }

        public int StoreId { get; set; }

        public string Location { get; set; }
    }
}
