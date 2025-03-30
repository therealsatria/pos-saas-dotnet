using System;
using System.Collections.Generic;

namespace Infrastructures.Entities
{
    public class Role : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public Dictionary<string, bool> Permissions { get; set; }
    }
}
