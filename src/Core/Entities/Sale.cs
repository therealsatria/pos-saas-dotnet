using System.Collections.Generic;

namespace Core.Entities
{
    public class Sale : BaseEntity
    {
        public Guid TenantId { get; set; }
        public Guid UserId { get; set; }
        public decimal TotalAmount { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public User User { get; set; }
        public ICollection<SaleItem> SaleItems { get; set; }
        public Payment Payment { get; set; }
    }
}
