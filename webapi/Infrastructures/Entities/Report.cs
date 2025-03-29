using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a report generated in the system
    /// </summary>
    public class Report : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Report class
        /// </summary>
        public Report()
        {
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the report type
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the report data (stored as JSON)
        /// </summary>
        [Required]
        public string Data { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
