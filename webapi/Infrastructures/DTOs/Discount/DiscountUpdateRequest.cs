using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Discount
{
    public class DiscountUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Discount name cannot exceed 50 characters")]
        public string Name { get; set; }

        public string DiscountType { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public decimal Value { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
