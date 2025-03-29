using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Permission
{
    public class PermissionCreateRequest
    {
        [Required(ErrorMessage = "Permission name is required")]
        [StringLength(50, ErrorMessage = "Permission name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Permission code is required")]
        [StringLength(50, ErrorMessage = "Permission code cannot exceed 50 characters")]
        public string Code { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Module name is required")]
        public string ModuleName { get; set; }
    }
}
