using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Customer
{
    public class CustomerCreateRequest
    {
        [Required(ErrorMessage = "Customer name is required")]
        [StringLength(100, ErrorMessage = "Customer name cannot exceed 100 characters")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
