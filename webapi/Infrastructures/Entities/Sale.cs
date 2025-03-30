using System;

namespace Infrastructures.Entities
{
    public class Sale : BaseEntity
    {
        public Guid TenantId { get; set; }
        public Guid UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
