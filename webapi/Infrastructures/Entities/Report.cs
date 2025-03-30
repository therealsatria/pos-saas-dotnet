using System;
using System.Text.Json;

namespace Infrastructures.Entities
{
    public class Report : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Type { get; set; }
        public JsonDocument Data { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
    }
}
