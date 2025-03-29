using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Inventory
{
    public class InventoryCreateRequest
    {
        [Required(ErrorMessage = "Product ID is required")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be non-negative")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        public int StoreId { get; set; }

        public string Location { get; set; }
    }
}
