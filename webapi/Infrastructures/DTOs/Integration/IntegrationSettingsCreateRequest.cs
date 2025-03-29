using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Integration
{
    public class IntegrationSettingsCreateRequest
    {
        [Required(ErrorMessage = "Integration type is required")]
        public string IntegrationType { get; set; }  // Payment Gateway, Accounting, E-commerce, etc.

        [Required(ErrorMessage = "Store ID is required")]
        public int StoreId { get; set; }

        [Required(ErrorMessage = "Provider name is required")]
        public string ProviderName { get; set; }

        public Dictionary<string, string> Credentials { get; set; }

        public Dictionary<string, string> Configuration { get; set; }

        public bool IsActive { get; set; }

        public string WebhookUrl { get; set; }

        public string ApiKey { get; set; }
    }
}
