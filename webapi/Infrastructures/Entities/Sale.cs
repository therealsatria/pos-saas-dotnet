using System;
using System.Collections.Generic;

namespace Infrastructures.Entities
{
    public class Sale : BaseEntity
    {
        public Guid TenantId { get; set; }
        public Guid UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? TaxId { get; set; }
        public Guid? DiscountId { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
        public User User { get; set; }
        public ICollection<SaleItem> SaleItems { get; set; }
        public Tax Tax { get; set; }
        public Discount Discount { get; set; }
        public Payment Payment { get; set; }
    }
}
