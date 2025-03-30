using System;

namespace pos_saas.Entities
{
    public class Tenant : BaseEntity
    {
        public string Name { get; set; }
        public string Subdomain { get; set; }
        public Guid PlanId { get; set; }
    }
}
