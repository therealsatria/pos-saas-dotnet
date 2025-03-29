using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Order
{
    public class OrderCreateRequest
    {
        [Required(ErrorMessage = "Customer ID is required")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Order items are required")]
        public List<OrderItemCreateRequest> OrderItems { get; set; }

        public string Notes { get; set; }
    }

    public class OrderItemCreateRequest
    {
        [Required(ErrorMessage = "Product ID is required")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }
    }
}
