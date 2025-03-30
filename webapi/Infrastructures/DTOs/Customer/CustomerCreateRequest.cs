using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Customer
{
    public class CustomerCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "Nama pelanggan diperlukan")]
        [StringLength(100, ErrorMessage = "Nama pelanggan tidak boleh lebih dari 100 karakter")]
        public string Name { get; set; }

        [StringLength(20, ErrorMessage = "Nomor telepon tidak boleh lebih dari 20 karakter")]
        [RegularExpression(@"^\+?[0-9\s\-\(\)]+$", ErrorMessage = "Format nomor telepon tidak valid")]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "Format email tidak valid")]
        [StringLength(100, ErrorMessage = "Email tidak boleh lebih dari 100 karakter")]
        public string Email { get; set; }
    }
} 