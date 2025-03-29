using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a log entry for inventory changes
    /// </summary>
    public class InventoryLog : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the InventoryLog class
        /// </summary>
        public InventoryLog()
        {
        }

        /// <summary>
        /// Gets or sets the inventory ID
        /// </summary>
        [Required]
        public Guid InventoryId { get; set; }

        /// <summary>
        /// Gets or sets the quantity changed
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the type of action performed
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string ActionType { get; set; } = string.Empty;  // restock/sale/adjustment

        /// <summary>
        /// Gets or sets the associated inventory
        /// </summary>
        [NotNull]
        public virtual Inventory? Inventory { get; set; }
    }
}
