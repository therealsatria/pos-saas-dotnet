using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Role
{
    public class RoleCreateRequest
    {
        [Required(ErrorMessage = "Role name is required")]
        [StringLength(50, ErrorMessage = "Role name cannot exceed 50 characters")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Permissions are required")]
        public List<int> PermissionIds { get; set; }
    }
}
