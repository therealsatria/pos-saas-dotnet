using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents inventory information for a product
    
    public class Inventory : BaseEntity
    {
        
        /// Initializes a new instance of the Inventory class
        
        public Inventory()
        {
            InventoryLogs = new HashSet<InventoryLog>();
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the product ID
        
        [Required]
        public Guid ProductId { get; set; }

        
        /// Gets or sets the stock quantity
        
        [Required]
        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        
        /// Gets or sets the inventory location
        
        [Required]
        [MaxLength(256)]
        public string Location { get; set; } = string.Empty;

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        
        /// Gets or sets the associated product
        
        [NotNull]
        public virtual Product? Product { get; set; }

        
        /// Gets or sets the collection of inventory logs
        
        public virtual ICollection<InventoryLog> InventoryLogs { get; set; }
    }
}
