using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.SaleItem
{
    public class SaleItemCreateRequest
    {
        public Guid? SaleId { get; set; }

        [Required(ErrorMessage = "ID produk diperlukan")]
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "Kuantitas diperlukan")]
        [Range(1, int.MaxValue, ErrorMessage = "Kuantitas harus lebih besar dari 0")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Harga satuan diperlukan")]
        [Range(0, double.MaxValue, ErrorMessage = "Harga satuan harus lebih besar dari 0")]
        public decimal UnitPrice { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Jumlah diskon harus lebih besar atau sama dengan 0")]
        public decimal DiscountAmount { get; set; }
    }
} 