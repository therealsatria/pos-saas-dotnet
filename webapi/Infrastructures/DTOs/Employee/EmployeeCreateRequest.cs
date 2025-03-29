using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Employee
{
    public class EmployeeCreateRequest
    {
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        public int StoreId { get; set; }

        [Required(ErrorMessage = "Role ID is required")]
        public int RoleId { get; set; }

        public DateTime? HireDate { get; set; }
    }
}
