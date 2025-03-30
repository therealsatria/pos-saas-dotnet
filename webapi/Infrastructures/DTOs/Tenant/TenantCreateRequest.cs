using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Tenant
{
    public class TenantCreateRequest
    {
        [Required(ErrorMessage = "Nama tenant diperlukan")]
        [StringLength(100, ErrorMessage = "Nama tenant tidak boleh lebih dari 100 karakter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Subdomain diperlukan")]
        [RegularExpression(@"^[a-z0-9]([a-z0-9\-]{0,61}[a-z0-9])?$", 
            ErrorMessage = "Subdomain hanya boleh berisi huruf kecil, angka, dan tanda strip")]
        public string Subdomain { get; set; }

        [Required(ErrorMessage = "ID rencana berlangganan diperlukan")]
        public Guid PlanId { get; set; }
    }
} 