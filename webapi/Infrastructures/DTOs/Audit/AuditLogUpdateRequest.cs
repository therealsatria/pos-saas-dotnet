using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Audit
{
    public class AuditLogUpdateRequest
    {
        public int Id { get; set; }
        
        public string Action { get; set; }
        
        public string OldValues { get; set; }
        
        public string NewValues { get; set; }
        
        public string AffectedColumns { get; set; }
        
        public string Comments { get; set; }
    }
}
