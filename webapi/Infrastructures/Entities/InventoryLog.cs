using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a log entry for inventory changes
    
    public class InventoryLog : BaseEntity
    {
        
        /// Initializes a new instance of the InventoryLog class
        
        public InventoryLog()
        {
        }

        
        /// Gets or sets the inventory ID
        
        [Required]
        public Guid InventoryId { get; set; }

        
        /// Gets or sets the quantity changed
        
        [Required]
        public int Quantity { get; set; }

        
        /// Gets or sets the type of action performed
        
        [Required]
        [MaxLength(50)]
        public string ActionType { get; set; } = string.Empty;  // restock/sale/adjustment

        
        /// Gets or sets the associated inventory
        
        [NotNull]
        public virtual Inventory? Inventory { get; set; }
    }
}
