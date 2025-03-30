using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Sale
{
    public class SaleUpdateRequest
    {
        [Range(0, double.MaxValue, ErrorMessage = "Total jumlah harus lebih besar dari 0")]
        public decimal? TotalAmount { get; set; }

        public Guid? TaxId { get; set; }

        public Guid? DiscountId { get; set; }
    }
} 