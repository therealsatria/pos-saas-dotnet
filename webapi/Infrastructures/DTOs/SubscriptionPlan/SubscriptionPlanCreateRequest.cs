using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Infrastructures.DTOs.SubscriptionPlan
{
    public class SubscriptionPlanCreateRequest
    {
        [Required(ErrorMessage = "Nama rencana berlangganan diperlukan")]
        [StringLength(100, ErrorMessage = "Nama rencana tidak boleh lebih dari 100 karakter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Harga diperlukan")]
        [Range(0, double.MaxValue, ErrorMessage = "Harga harus lebih besar dari 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Fitur-fitur diperlukan")]
        public string Features { get; set; } // JSON string yang akan dikonversi ke JsonDocument
    }
} 