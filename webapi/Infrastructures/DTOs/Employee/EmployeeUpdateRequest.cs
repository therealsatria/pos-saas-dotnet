using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Employee
{
    public class EmployeeUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        public int StoreId { get; set; }
        public int RoleId { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
