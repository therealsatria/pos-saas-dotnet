using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Report
{
    public class ReportUpdateRequest
    {
        [StringLength(50, ErrorMessage = "Tipe laporan tidak boleh lebih dari 50 karakter")]
        public string Type { get; set; }

        public string Data { get; set; } // JSON string yang akan dikonversi ke JsonDocument
    }
} 