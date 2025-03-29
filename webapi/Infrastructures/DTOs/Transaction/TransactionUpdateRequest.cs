using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Transaction
{
    public class TransactionUpdateRequest
    {
        public int Id { get; set; }

        public string TransactionType { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        public int StoreId { get; set; }

        public int? OrderId { get; set; }

        public string Description { get; set; }

        public string ReferenceNumber { get; set; }

        public string Status { get; set; }
    }
}
