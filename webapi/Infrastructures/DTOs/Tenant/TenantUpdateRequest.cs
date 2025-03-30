using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Tenant
{
    public class TenantUpdateRequest
    {
        [Required(ErrorMessage = "Nama tenant diperlukan")]
        [StringLength(100, ErrorMessage = "Nama tenant tidak boleh lebih dari 100 karakter")]
        public string Name { get; set; }

        [RegularExpression(@"^[a-z0-9]([a-z0-9\-]{0,61}[a-z0-9])?$", 
            ErrorMessage = "Subdomain hanya boleh berisi huruf kecil, angka, dan tanda strip")]
        public string Subdomain { get; set; }
        
        public Guid? PlanId { get; set; }
    }
} 