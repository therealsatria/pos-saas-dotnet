using System;

namespace pos_saas.Entities
{
    public class Supplier : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}
