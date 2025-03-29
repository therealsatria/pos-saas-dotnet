using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.PurchaseOrder
{
    public class PurchaseOrderCreateRequest
    {
        [Required(ErrorMessage = "Supplier ID is required")]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        public int StoreId { get; set; }

        [Required(ErrorMessage = "Purchase order items are required")]
        public List<PurchaseOrderItemCreateRequest> Items { get; set; }

        public string Notes { get; set; }

        public DateTime? ExpectedDeliveryDate { get; set; }
    }

    public class PurchaseOrderItemCreateRequest
    {
        [Required(ErrorMessage = "Product ID is required")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Unit price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Unit price must be greater than 0")]
        public decimal UnitPrice { get; set; }
    }
}
