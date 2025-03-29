using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.PurchaseOrder
{
    public class PurchaseOrderUpdateRequest
    {
        public int Id { get; set; }

        public int SupplierId { get; set; }

        public int StoreId { get; set; }

        public List<PurchaseOrderItemUpdateRequest> Items { get; set; }

        public string Notes { get; set; }

        public DateTime? ExpectedDeliveryDate { get; set; }

        public string Status { get; set; }
    }

    public class PurchaseOrderItemUpdateRequest
    {
        public int ProductId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Unit price must be greater than 0")]
        public decimal UnitPrice { get; set; }
    }
}
