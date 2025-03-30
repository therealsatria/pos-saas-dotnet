using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a payment gateway configuration for a tenant
    
    public class PaymentGateway : BaseEntity
    {
        
        /// Initializes a new instance of the PaymentGateway class
        
        public PaymentGateway()
        {
        }

        
        /// Gets or sets the tenant ID
        
        [Required]
        public Guid TenantId { get; set; }

        
        /// Gets or sets the gateway type (e.g., stripe, midtrans)
        
        [Required]
        [MaxLength(50)]
        public string Type { get; set; } = string.Empty;

        
        /// Gets or sets the encrypted API key
        
        [Required]
        public string ApiKeyEncrypted { get; set; } = string.Empty;

        
        /// Gets or sets the associated tenant
        
        [NotNull]
        public virtual Tenant? Tenant { get; set; }
    }
}
