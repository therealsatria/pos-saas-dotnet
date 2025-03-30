using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.LoyaltyProgram
{
    public class LoyaltyProgramUpdateRequest
    {
        [StringLength(100, ErrorMessage = "Nama program loyalitas tidak boleh lebih dari 100 karakter")]
        public string Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Tingkat poin harus lebih besar dari 0")]
        public decimal? PointsRate { get; set; } // Points per currency
    }
} 