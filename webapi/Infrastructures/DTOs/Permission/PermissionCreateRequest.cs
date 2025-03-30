using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Permission
{
    public class PermissionCreateRequest
    {
        [Required(ErrorMessage = "Nama izin diperlukan")]
        [StringLength(50, ErrorMessage = "Nama izin tidak boleh lebih dari 50 karakter")]
        public string Name { get; set; }

        [StringLength(255, ErrorMessage = "Deskripsi tidak boleh lebih dari 255 karakter")]
        public string Description { get; set; }

        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }
    }
} 