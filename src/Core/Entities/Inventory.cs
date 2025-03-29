using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Core.Entities
{
    /// <summary>
    /// Represents inventory information for a product
    /// </summary>
    public class Inventory : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Inventory class
        /// </summary>
        public Inventory()
        {
            InventoryLogs = new HashSet<InventoryLog>();
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the product ID
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the stock quantity
        /// </summary>
        [Required]
        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        /// <summary>
        /// Gets or sets the inventory location
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Gets or sets the associated product
        /// </summary>
        [NotNull]
        public virtual Product? Product { get; set; }

        /// <summary>
        /// Gets or sets the collection of inventory logs
        /// </summary>
        public virtual ICollection<InventoryLog> InventoryLogs { get; set; }
    }
}
