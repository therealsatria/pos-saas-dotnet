using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Inventory
{
    public class InventoryUpdateRequest
    {
        [Range(0, int.MaxValue, ErrorMessage = "Stok tidak boleh negatif")]
        public int? Stock { get; set; }

        [StringLength(100, ErrorMessage = "Lokasi tidak boleh lebih dari 100 karakter")]
        public string Location { get; set; }
    }
} 