using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Payment
{
    public class PaymentCreateRequest
    {
        [Required(ErrorMessage = "ID penjualan diperlukan")]
        public Guid SaleId { get; set; }

        [Required(ErrorMessage = "Metode pembayaran diperlukan")]
        [StringLength(20, ErrorMessage = "Metode pembayaran tidak boleh lebih dari 20 karakter")]
        public string Method { get; set; } // cash/card/ewallet

        [Required(ErrorMessage = "Jumlah pembayaran diperlukan")]
        [Range(0, double.MaxValue, ErrorMessage = "Jumlah pembayaran harus lebih besar dari 0")]
        public decimal Amount { get; set; }

        public string TransactionId { get; set; }
    }
} 