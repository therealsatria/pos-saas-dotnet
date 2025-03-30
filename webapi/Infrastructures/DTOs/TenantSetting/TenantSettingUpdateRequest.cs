using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.TenantSetting
{
    public class TenantSettingUpdateRequest
    {
        [StringLength(50, ErrorMessage = "Kunci pengaturan tidak boleh lebih dari 50 karakter")]
        public string SettingKey { get; set; }

        public string SettingValue { get; set; }
    }
} 