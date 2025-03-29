using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Promotion
{
    public class PromotionUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "Promotion name cannot exceed 100 characters")]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string PromotionType { get; set; }

        public List<int> ProductIds { get; set; }

        public List<int> CategoryIds { get; set; }

        public decimal MinimumPurchaseAmount { get; set; }

        public bool IsActive { get; set; }
    }
}
