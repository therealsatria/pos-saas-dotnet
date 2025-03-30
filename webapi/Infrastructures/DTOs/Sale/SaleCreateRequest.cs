using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Infrastructures.DTOs.SaleItem;

namespace Infrastructures.DTOs.Sale
{
    public class SaleCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "ID pengguna diperlukan")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Total jumlah diperlukan")]
        [Range(0, double.MaxValue, ErrorMessage = "Total jumlah harus lebih besar dari 0")]
        public decimal TotalAmount { get; set; }

        public Guid? TaxId { get; set; }

        public Guid? DiscountId { get; set; }

        [Required(ErrorMessage = "Item penjualan diperlukan")]
        public List<SaleItemCreateRequest> SaleItems { get; set; }
    }
} 