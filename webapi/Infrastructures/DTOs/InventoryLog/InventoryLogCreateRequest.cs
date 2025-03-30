using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.InventoryLog
{
    public class InventoryLogCreateRequest
    {
        [Required(ErrorMessage = "ID inventaris diperlukan")]
        public Guid InventoryId { get; set; }

        [Required(ErrorMessage = "Kuantitas diperlukan")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Tipe aksi diperlukan")]
        [StringLength(20, ErrorMessage = "Tipe aksi tidak boleh lebih dari 20 karakter")]
        public string ActionType { get; set; } // restock/sale/adjustment
    }
} 