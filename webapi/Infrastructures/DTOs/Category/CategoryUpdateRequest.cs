using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Category
{
    public class CategoryUpdateRequest
    {
        [StringLength(50, ErrorMessage = "Nama kategori tidak boleh lebih dari 50 karakter")]
        public string Name { get; set; }

        public Guid? ParentId { get; set; }
    }
} 