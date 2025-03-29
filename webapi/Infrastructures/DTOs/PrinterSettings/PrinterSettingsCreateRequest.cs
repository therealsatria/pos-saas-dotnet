using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.PrinterSettings
{
    public class PrinterSettingsCreateRequest
    {
        [Required(ErrorMessage = "Printer name is required")]
        public string PrinterName { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        public int StoreId { get; set; }

        public string IPAddress { get; set; }

        public int? Port { get; set; }

        [Required(ErrorMessage = "Printer type is required")]
        public string PrinterType { get; set; }  // Receipt, Kitchen, Label, etc.

        public bool IsDefault { get; set; }

        public Dictionary<string, string> PrinterConfig { get; set; }
    }
}
