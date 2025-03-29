using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Discount
{
    public class DiscountCreateRequest
    {
        [Required(ErrorMessage = "Discount name is required")]
        [StringLength(50, ErrorMessage = "Discount name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Discount type is required")]
        public string DiscountType { get; set; } // Percentage or Fixed Amount

        [Required(ErrorMessage = "Value is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public decimal Value { get; set; }

        public DateTime? StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }

        public bool IsActive { get; set; }
    }
}
