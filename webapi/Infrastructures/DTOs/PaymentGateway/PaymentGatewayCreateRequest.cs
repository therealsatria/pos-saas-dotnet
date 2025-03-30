using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.PaymentGateway
{
    public class PaymentGatewayCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "Tipe gateway pembayaran diperlukan")]
        [RegularExpression("^(stripe|midtrans)$", ErrorMessage = "Tipe gateway pembayaran harus berupa 'stripe' atau 'midtrans'")]
        public string Type { get; set; } // stripe/midtrans

        [Required(ErrorMessage = "API key diperlukan")]
        public string ApiKeyEncrypted { get; set; }
    }
} 