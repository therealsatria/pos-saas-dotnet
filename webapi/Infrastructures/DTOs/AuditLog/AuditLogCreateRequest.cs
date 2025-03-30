using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.AuditLog
{
    public class AuditLogCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "ID pengguna diperlukan")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Aksi diperlukan")]
        [StringLength(255, ErrorMessage = "Aksi tidak boleh lebih dari 255 karakter")]
        public string Action { get; set; }
    }
} 