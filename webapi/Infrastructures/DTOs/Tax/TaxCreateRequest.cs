using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Tax
{
    public class TaxCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "Nama pajak diperlukan")]
        [StringLength(50, ErrorMessage = "Nama pajak tidak boleh lebih dari 50 karakter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Tarif pajak diperlukan")]
        [Range(0, 100, ErrorMessage = "Tarif pajak harus antara 0 dan 100 persen")]
        public decimal Rate { get; set; }
    }
} 