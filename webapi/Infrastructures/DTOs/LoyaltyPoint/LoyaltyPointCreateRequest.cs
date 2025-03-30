using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.LoyaltyPoint
{
    public class LoyaltyPointCreateRequest
    {
        [Required(ErrorMessage = "ID pelanggan diperlukan")]
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "ID program loyalitas diperlukan")]
        public Guid LoyaltyProgramId { get; set; }

        [Required(ErrorMessage = "Saldo poin diperlukan")]
        [Range(0, int.MaxValue, ErrorMessage = "Saldo poin tidak boleh negatif")]
        public int Balance { get; set; }
    }
} 