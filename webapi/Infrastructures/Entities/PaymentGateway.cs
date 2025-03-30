using System;

namespace Infrastructures.Entities
{
    public class PaymentGateway : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Type { get; set; }
        public string ApiKeyEncrypted { get; set; }
    }
}
