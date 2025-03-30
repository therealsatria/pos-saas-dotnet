using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Inventory
{
    public class InventoryCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "ID produk diperlukan")]
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "Stok diperlukan")]
        [Range(0, int.MaxValue, ErrorMessage = "Stok tidak boleh negatif")]
        public int Stock { get; set; }

        [StringLength(100, ErrorMessage = "Lokasi tidak boleh lebih dari 100 karakter")]
        public string Location { get; set; }
    }
} 