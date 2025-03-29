using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Settings
{
    public class SystemSettingsUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Setting key cannot exceed 50 characters")]
        public string Key { get; set; }

        public string Value { get; set; }
        
        public string Group { get; set; }
        
        public string Description { get; set; }
        
        public bool IsSystem { get; set; }
    }
}
