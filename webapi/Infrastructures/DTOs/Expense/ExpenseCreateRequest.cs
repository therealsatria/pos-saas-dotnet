using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Expense
{
    public class ExpenseCreateRequest
    {
        [Required(ErrorMessage = "Expense type is required")]
        public string ExpenseType { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        public int StoreId { get; set; }

        public DateTime ExpenseDate { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Employee ID is required")]
        public int EmployeeId { get; set; }

        public string ReceiptNumber { get; set; }
    }
}
