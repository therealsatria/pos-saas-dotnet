using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Loyalty
{
    public class LoyaltyProgramUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "Program name cannot exceed 100 characters")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Points per currency must be greater than 0")]
        public decimal PointsPerCurrency { get; set; }

        public int MinimumPointsForRedemption { get; set; }

        public decimal RedemptionRate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public bool IsActive { get; set; }
    }
}
