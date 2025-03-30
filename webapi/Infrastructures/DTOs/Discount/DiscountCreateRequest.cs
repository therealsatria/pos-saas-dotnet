using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Discount
{
    public class DiscountCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "Kode diskon diperlukan")]
        [StringLength(20, ErrorMessage = "Kode diskon tidak boleh lebih dari 20 karakter")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Nilai diskon diperlukan")]
        [Range(0, double.MaxValue, ErrorMessage = "Nilai diskon harus lebih besar dari 0")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "Tipe diskon diperlukan")]
        [RegularExpression("^(percentage|fixed)$", ErrorMessage = "Tipe diskon harus berupa 'percentage' atau 'fixed'")]
        public string Type { get; set; } // percentage/fixed
    }
} 