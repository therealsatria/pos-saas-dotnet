using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.CashRegister
{
    public class CashRegisterUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Register name cannot exceed 50 characters")]
        public string Name { get; set; }

        public string Location { get; set; }

        public string IPAddress { get; set; }

        public bool IsActive { get; set; }

        public string Status { get; set; }
    }
}
