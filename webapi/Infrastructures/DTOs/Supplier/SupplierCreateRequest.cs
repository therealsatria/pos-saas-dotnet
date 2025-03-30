using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Supplier
{
    public class SupplierCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "Nama pemasok diperlukan")]
        [StringLength(100, ErrorMessage = "Nama pemasok tidak boleh lebih dari 100 karakter")]
        public string Name { get; set; }

        [StringLength(255, ErrorMessage = "Kontak tidak boleh lebih dari 255 karakter")]
        public string Contact { get; set; }
    }
} 