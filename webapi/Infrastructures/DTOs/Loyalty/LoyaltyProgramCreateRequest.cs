using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Loyalty
{
    public class LoyaltyProgramCreateRequest
    {
        [Required(ErrorMessage = "Program name is required")]
        [StringLength(100, ErrorMessage = "Program name cannot exceed 100 characters")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Points per currency is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Points per currency must be greater than 0")]
        public decimal PointsPerCurrency { get; set; }

        [Required(ErrorMessage = "Minimum points for redemption is required")]
        public int MinimumPointsForRedemption { get; set; }

        public decimal RedemptionRate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public bool IsActive { get; set; }
    }
}
