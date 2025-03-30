using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.RolePermission
{
    public class RolePermissionCreateRequest
    {
        [Required(ErrorMessage = "ID peran diperlukan")]
        public Guid RoleId { get; set; }

        [Required(ErrorMessage = "ID izin diperlukan")]
        public Guid PermissionId { get; set; }
    }
} 