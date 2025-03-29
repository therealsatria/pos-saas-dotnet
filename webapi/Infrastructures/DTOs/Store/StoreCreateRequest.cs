using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Store
{
    public class StoreCreateRequest
    {
        [Required(ErrorMessage = "Store name is required")]
        [StringLength(100, ErrorMessage = "Store name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        public string BusinessHours { get; set; }
    }
}
