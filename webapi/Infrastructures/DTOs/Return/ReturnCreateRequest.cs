using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Return
{
    public class ReturnCreateRequest
    {
        [Required(ErrorMessage = "Order ID is required")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Return items are required")]
        public List<ReturnItemCreateRequest> Items { get; set; }

        [Required(ErrorMessage = "Return reason is required")]
        public string ReturnReason { get; set; }

        public string Notes { get; set; }
    }

    public class ReturnItemCreateRequest
    {
        [Required(ErrorMessage = "Order item ID is required")]
        public int OrderItemId { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Return reason is required")]
        public string ReturnReason { get; set; }
    }
}
