using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Tax
{
    public class TaxUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Tax name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Range(0, 100, ErrorMessage = "Rate must be between 0 and 100")]
        public decimal Rate { get; set; }

        public bool IsActive { get; set; }
        
        public string Description { get; set; }
    }
}
