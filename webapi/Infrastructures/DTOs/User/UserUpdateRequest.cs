using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.User
{
    public class UserUpdateRequest
    {
        [EmailAddress(ErrorMessage = "Format email tidak valid")]
        public string Email { get; set; }

        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password harus minimal 8 karakter")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(20, ErrorMessage = "Status tidak boleh lebih dari 20 karakter")]
        public string Status { get; set; }
    }
} 