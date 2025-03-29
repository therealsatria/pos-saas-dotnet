using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Promotion
{
    public class PromotionCreateRequest
    {
        [Required(ErrorMessage = "Promotion name is required")]
        [StringLength(100, ErrorMessage = "Promotion name cannot exceed 100 characters")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "Promotion type is required")]
        public string PromotionType { get; set; }

        public List<int> ProductIds { get; set; }

        public List<int> CategoryIds { get; set; }

        public decimal MinimumPurchaseAmount { get; set; }

        public bool IsActive { get; set; }
    }
}
