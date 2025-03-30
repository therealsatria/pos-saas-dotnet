using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.UserRole
{
    public class UserRoleCreateRequest
    {
        [Required(ErrorMessage = "ID pengguna diperlukan")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "ID peran diperlukan")]
        public Guid RoleId { get; set; }
    }
} 