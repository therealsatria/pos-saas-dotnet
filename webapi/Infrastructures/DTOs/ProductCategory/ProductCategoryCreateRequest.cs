using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.ProductCategory
{
    public class ProductCategoryCreateRequest
    {
        [Required(ErrorMessage = "ID produk diperlukan")]
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "ID kategori diperlukan")]
        public Guid CategoryId { get; set; }
    }
} 