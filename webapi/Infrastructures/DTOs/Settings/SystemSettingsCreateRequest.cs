using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Settings
{
    public class SystemSettingsCreateRequest
    {
        [Required(ErrorMessage = "Setting key is required")]
        [StringLength(50, ErrorMessage = "Setting key cannot exceed 50 characters")]
        public string Key { get; set; }

        [Required(ErrorMessage = "Setting value is required")]
        public string Value { get; set; }

        public string Group { get; set; }

        public string Description { get; set; }

        public bool IsSystem { get; set; }

        public int? StoreId { get; set; }
    }
}
