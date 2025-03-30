using System;

namespace pos_saas.Entities
{
    public class TenantSetting : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
    }
}
