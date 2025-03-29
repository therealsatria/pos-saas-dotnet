using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.UnitOfMeasure
{
    public class UnitOfMeasureCreateRequest
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, ErrorMessage = "Name cannot exceed 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Abbreviation is required")]
        [StringLength(5, ErrorMessage = "Abbreviation cannot exceed 5 characters")]
        public string Abbreviation { get; set; }

        public string Description { get; set; }
    }
}
