using System;

namespace pos_saas.Entities
{
    public class Tax : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
    }
}
