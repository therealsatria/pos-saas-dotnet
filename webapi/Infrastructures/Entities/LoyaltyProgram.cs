using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a loyalty program configuration
    
    public class LoyaltyProgram : BaseEntity
    {
        
        /// Initializes a new instance of the LoyaltyProgram class
        
        public LoyaltyProgram()
        {
            LoyaltyPoints = new HashSet<LoyaltyPoints>();
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the program name
        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        
        /// Gets or sets the points rate (points per currency unit)
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal PointsRate { get; set; }

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }

        
        /// Gets or sets the collection of loyalty points
        
        public virtual ICollection<LoyaltyPoints> LoyaltyPoints { get; set; }
    }
}
