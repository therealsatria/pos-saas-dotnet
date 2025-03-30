using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.PaymentGateway
{
    public class PaymentGatewayUpdateRequest
    {
        [RegularExpression("^(stripe|midtrans)$", ErrorMessage = "Tipe gateway pembayaran harus berupa 'stripe' atau 'midtrans'")]
        public string Type { get; set; } // stripe/midtrans

        public string ApiKeyEncrypted { get; set; }
    }
} 