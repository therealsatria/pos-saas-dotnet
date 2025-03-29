namespace Core.Entities
{
    public class TenantSetting : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        
        // Navigation properties
        public Tenant Tenant { get; set; }
    }
}
