using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Transaction
{
    public class TransactionCreateRequest
    {
        [Required(ErrorMessage = "Transaction type is required")]
        public string TransactionType { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        public int StoreId { get; set; }

        public int? OrderId { get; set; }

        public string Description { get; set; }

        public string ReferenceNumber { get; set; }
    }
}
