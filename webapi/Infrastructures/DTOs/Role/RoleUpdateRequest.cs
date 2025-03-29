using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Role
{
    public class RoleUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Role name cannot exceed 50 characters")]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<int> PermissionIds { get; set; }
    }
}
