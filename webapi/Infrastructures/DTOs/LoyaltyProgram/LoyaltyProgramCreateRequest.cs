using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.LoyaltyProgram
{
    public class LoyaltyProgramCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "Nama program loyalitas diperlukan")]
        [StringLength(100, ErrorMessage = "Nama program loyalitas tidak boleh lebih dari 100 karakter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Tingkat poin diperlukan")]
        [Range(0, double.MaxValue, ErrorMessage = "Tingkat poin harus lebih besar dari 0")]
        public decimal PointsRate { get; set; } // Points per currency
    }
} 