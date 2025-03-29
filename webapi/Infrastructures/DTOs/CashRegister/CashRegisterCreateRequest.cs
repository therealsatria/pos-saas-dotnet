using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.CashRegister
{
    public class CashRegisterCreateRequest
    {
        [Required(ErrorMessage = "Register name is required")]
        [StringLength(50, ErrorMessage = "Register name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        public int StoreId { get; set; }

        public string Location { get; set; }

        public string IPAddress { get; set; }

        public bool IsActive { get; set; }
    }
}
