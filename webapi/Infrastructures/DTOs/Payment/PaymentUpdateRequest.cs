using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Payment
{
    public class PaymentUpdateRequest
    {
        [StringLength(20, ErrorMessage = "Metode pembayaran tidak boleh lebih dari 20 karakter")]
        public string Method { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Jumlah pembayaran harus lebih besar dari 0")]
        public decimal? Amount { get; set; }

        public string TransactionId { get; set; }
    }
} 