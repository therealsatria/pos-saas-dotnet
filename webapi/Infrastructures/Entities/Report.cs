using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a report generated in the system
    
    public class Report : BaseEntity
    {
        
        /// Initializes a new instance of the Report class
        
        public Report()
        {
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the report type
        
        [Required]
        [MaxLength(50)]
        public string Type { get; set; } = string.Empty;

        
        /// Gets or sets the report data (stored as JSON)
        
        [Required]
        public string Data { get; set; } = string.Empty;

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
