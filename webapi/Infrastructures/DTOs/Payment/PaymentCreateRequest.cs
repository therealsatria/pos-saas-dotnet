using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Payment
{
    public class PaymentCreateRequest
    {
        [Required(ErrorMessage = "Order ID is required")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Payment amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Payment method is required")]
        public string PaymentMethod { get; set; }

        public string TransactionReference { get; set; }
    }
}
