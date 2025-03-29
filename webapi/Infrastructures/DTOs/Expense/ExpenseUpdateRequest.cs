using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Expense
{
    public class ExpenseUpdateRequest
    {
        public int Id { get; set; }

        public string ExpenseType { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        public DateTime ExpenseDate { get; set; }

        public string Description { get; set; }

        public string ReceiptNumber { get; set; }

        public string Status { get; set; }
    }
}
