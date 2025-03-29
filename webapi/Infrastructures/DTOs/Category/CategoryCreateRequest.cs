using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Category
{
    public class CategoryCreateRequest
    {
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(50, ErrorMessage = "Category name cannot exceed 50 characters")]
        public string Name { get; set; }

        public string Description { get; set; }
        
        public int? ParentCategoryId { get; set; }
    }
}
