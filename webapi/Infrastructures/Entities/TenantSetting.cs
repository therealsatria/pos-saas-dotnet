using System;

namespace Infrastructures.Entities
{
    public class TenantSetting : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
    }
}
