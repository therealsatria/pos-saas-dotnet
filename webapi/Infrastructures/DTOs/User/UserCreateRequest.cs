using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.User
{
    public class UserCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "Email diperlukan")]
        [EmailAddress(ErrorMessage = "Format email tidak valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password diperlukan")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password harus minimal 8 karakter")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Status diperlukan")]
        [StringLength(20, ErrorMessage = "Status tidak boleh lebih dari 20 karakter")]
        public string Status { get; set; }
    }
}