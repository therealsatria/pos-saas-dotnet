using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Backup
{
    public class BackupCreateRequest
    {
        [Required(ErrorMessage = "Backup type is required")]
        public string BackupType { get; set; }  // Full, Incremental, Settings

        [Required(ErrorMessage = "Store ID is required")]
        public int StoreId { get; set; }

        public string Description { get; set; }

        public bool IncludeTransactions { get; set; }

        public bool IncludeProducts { get; set; }

        public bool IncludeCustomers { get; set; }

        public DateTime? FromDate { get; set; }

        public string StorageLocation { get; set; }
    }
}
