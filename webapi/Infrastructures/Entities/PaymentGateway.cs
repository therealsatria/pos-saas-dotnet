using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    /// <summary>
    /// Represents a payment gateway configuration for a tenant
    /// </summary>
    public class PaymentGateway : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the PaymentGateway class
        /// </summary>
        public PaymentGateway()
        {
        }

        /// <summary>
        /// Gets or sets the tenant ID
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the gateway type (e.g., stripe, midtrans)
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the encrypted API key
        /// </summary>
        [Required]
        public string ApiKeyEncrypted { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the associated tenant
        /// </summary>
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
