using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.ProductVariant
{
    public class ProductVariantCreateRequest
    {
        [Required(ErrorMessage = "Product ID is required")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "SKU is required")]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters")]
        public string SKU { get; set; }

        [Required(ErrorMessage = "Variant name is required")]
        [StringLength(100, ErrorMessage = "Variant name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        public Dictionary<string, string> Attributes { get; set; }
    }
}
