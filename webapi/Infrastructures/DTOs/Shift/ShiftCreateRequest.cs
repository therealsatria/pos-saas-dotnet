using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Shift
{
    public class ShiftCreateRequest
    {
        [Required(ErrorMessage = "Employee ID is required")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        public int StoreId { get; set; }

        [Required(ErrorMessage = "Start time is required")]
        public DateTime StartTime { get; set; }

        public decimal StartingCashAmount { get; set; }

        [Required(ErrorMessage = "Cash register ID is required")]
        public int CashRegisterId { get; set; }
    }
}
