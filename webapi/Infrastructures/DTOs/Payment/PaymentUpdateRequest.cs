using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Payment
{
    public class PaymentUpdateRequest
    {
        public int Id { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; }
        
        public string TransactionReference { get; set; }
        
        public string Status { get; set; }
    }
}
