using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.LoyaltyPoint
{
    public class LoyaltyPointUpdateRequest
    {
        public Guid? LoyaltyProgramId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Saldo poin tidak boleh negatif")]
        public int? Balance { get; set; }
    }
} 