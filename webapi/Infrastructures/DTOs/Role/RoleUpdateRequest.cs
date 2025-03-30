using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Role
{
    public class RoleUpdateRequest
    {
        [StringLength(50, ErrorMessage = "Nama peran tidak boleh lebih dari 50 karakter")]
        public string Name { get; set; }

        public string Permissions { get; set; } // JSON string yang akan dikonversi ke JsonDocument
    }
} 