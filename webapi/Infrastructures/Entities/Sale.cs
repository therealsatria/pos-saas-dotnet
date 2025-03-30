using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a sales transaction in the system
    
    public class Sale : BaseEntity
    {
        
        /// Initializes a new instance of the Sale class
        
        public Sale()
        {
            SaleItems = new HashSet<SaleItem>();
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the user ID who made the sale
        
        [Required]
        public Guid UserId { get; set; }

        
        /// Gets or sets the total amount of the sale
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotalAmount { get; set; }

        
        /// Gets or sets the tax ID
        
        public Guid? TaxId { get; set; }

        
        /// Gets or sets the discount ID
        
        public Guid? DiscountId { get; set; }

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        
        /// Gets or sets the associated user
        
        [NotNull]
        public virtual User? User { get; set; }

        
        /// Gets or sets the associated tax
        
        public virtual Tax? Tax { get; set; }

        
        /// Gets or sets the associated discount
        
        public virtual Discount? Discount { get; set; }

        
        /// Gets or sets the collection of sale items
        
        public virtual ICollection<SaleItem> SaleItems { get; set; }

        
        /// Gets or sets the associated payment
        
        public virtual Payment? Payment { get; set; }
    }
}
