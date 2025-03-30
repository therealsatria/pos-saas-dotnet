using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Product
{
    public class ProductUpdateRequest
    {
        [StringLength(50, ErrorMessage = "SKU tidak boleh lebih dari 50 karakter")]
        public string Sku { get; set; }

        [StringLength(100, ErrorMessage = "Nama produk tidak boleh lebih dari 100 karakter")]
        public string Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Harga jual harus lebih besar dari 0")]
        public decimal? Price { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Harga modal harus lebih besar dari 0")]
        public decimal? CostPrice { get; set; }

        [StringLength(20, ErrorMessage = "Satuan ukuran tidak boleh lebih dari 20 karakter")]
        public string UnitOfMeasure { get; set; }

        public Guid? SupplierId { get; set; }
    }
} 