using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Supplier
{
    public class SupplierUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "Supplier name cannot exceed 100 characters")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        
        public string ContactPerson { get; set; }
    }
}
