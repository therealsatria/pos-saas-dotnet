using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Store
{
    public class StoreUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "Store name cannot exceed 100 characters")]
        public string Name { get; set; }

        public string Address { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        public string BusinessHours { get; set; }
    }
}
