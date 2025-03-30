using System;

namespace Infrastructures.Entities
{
    public class PaymentGateway : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Type { get; set; } // stripe/midtrans
        public string ApiKeyEncrypted { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
    }
}
