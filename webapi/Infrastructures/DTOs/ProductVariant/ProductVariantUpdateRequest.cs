using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.ProductVariant
{
    public class ProductVariantUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters")]
        public string SKU { get; set; }

        [StringLength(100, ErrorMessage = "Variant name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        public Dictionary<string, string> Attributes { get; set; }
    }
}
