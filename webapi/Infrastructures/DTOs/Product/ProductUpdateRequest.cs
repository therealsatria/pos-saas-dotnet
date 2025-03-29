using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Product
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
