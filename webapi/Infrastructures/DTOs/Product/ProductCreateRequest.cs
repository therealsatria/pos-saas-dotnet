using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Product
{
    public class ProductCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "SKU produk diperlukan")]
        [StringLength(50, ErrorMessage = "SKU tidak boleh lebih dari 50 karakter")]
        public string Sku { get; set; }

        [Required(ErrorMessage = "Nama produk diperlukan")]
        [StringLength(100, ErrorMessage = "Nama produk tidak boleh lebih dari 100 karakter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Harga jual diperlukan")]
        [Range(0, double.MaxValue, ErrorMessage = "Harga jual harus lebih besar dari 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Harga modal diperlukan")]
        [Range(0, double.MaxValue, ErrorMessage = "Harga modal harus lebih besar dari 0")]
        public decimal CostPrice { get; set; }

        [Required(ErrorMessage = "Satuan ukuran diperlukan")]
        [StringLength(20, ErrorMessage = "Satuan ukuran tidak boleh lebih dari 20 karakter")]
        public string UnitOfMeasure { get; set; }

        public Guid? SupplierId { get; set; }
    }
} 