using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.SubscriptionPlan
{
    public class SubscriptionPlanUpdateRequest
    {
        [StringLength(100, ErrorMessage = "Nama rencana tidak boleh lebih dari 100 karakter")]
        public string Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Harga harus lebih besar dari 0")]
        public decimal? Price { get; set; }

        public string Features { get; set; } // JSON string yang akan dikonversi ke JsonDocument
    }
} 