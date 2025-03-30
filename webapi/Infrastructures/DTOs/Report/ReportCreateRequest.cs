using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Report
{
    public class ReportCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "Tipe laporan diperlukan")]
        [StringLength(50, ErrorMessage = "Tipe laporan tidak boleh lebih dari 50 karakter")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Data laporan diperlukan")]
        public string Data { get; set; } // JSON string yang akan dikonversi ke JsonDocument
    }
} 