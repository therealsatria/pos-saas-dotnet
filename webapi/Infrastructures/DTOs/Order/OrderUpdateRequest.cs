using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Order
{
    public class OrderUpdateRequest
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public List<OrderItemUpdateRequest> OrderItems { get; set; }

        public string Notes { get; set; }

        public string Status { get; set; }
    }

    public class OrderItemUpdateRequest
    {
        [Required(ErrorMessage = "Product ID is required")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }
    }
}
