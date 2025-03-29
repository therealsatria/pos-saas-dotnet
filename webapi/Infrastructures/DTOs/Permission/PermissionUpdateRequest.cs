using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Permission
{
    public class PermissionUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Permission name cannot exceed 50 characters")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Permission code cannot exceed 50 characters")]
        public string Code { get; set; }

        public string Description { get; set; }

        public string ModuleName { get; set; }
    }
}
