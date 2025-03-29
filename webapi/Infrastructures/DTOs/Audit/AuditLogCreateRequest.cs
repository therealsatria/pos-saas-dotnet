using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Audit
{
    public class AuditLogCreateRequest
    {
        [Required]
        public string EntityName { get; set; }

        [Required]
        public string Action { get; set; }

        [Required]
        public int EntityId { get; set; }

        [Required]
        public int UserId { get; set; }

        public string OldValues { get; set; }

        public string NewValues { get; set; }

        public string AffectedColumns { get; set; }

        public int? StoreId { get; set; }
    }
}
