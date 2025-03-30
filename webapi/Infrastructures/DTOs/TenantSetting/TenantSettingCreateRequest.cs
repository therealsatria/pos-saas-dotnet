using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.TenantSetting
{
    public class TenantSettingCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "Kunci pengaturan diperlukan")]
        [StringLength(50, ErrorMessage = "Kunci pengaturan tidak boleh lebih dari 50 karakter")]
        public string SettingKey { get; set; }

        [Required(ErrorMessage = "Nilai pengaturan diperlukan")]
        public string SettingValue { get; set; }
    }
} 