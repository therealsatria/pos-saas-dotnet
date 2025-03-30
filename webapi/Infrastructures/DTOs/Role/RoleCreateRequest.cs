using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Infrastructures.DTOs.Role
{
    public class RoleCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "Nama peran diperlukan")]
        [StringLength(50, ErrorMessage = "Nama peran tidak boleh lebih dari 50 karakter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Izin-izin diperlukan")]
        public string Permissions { get; set; } // JSON string yang akan dikonversi ke JsonDocument
    }
} 