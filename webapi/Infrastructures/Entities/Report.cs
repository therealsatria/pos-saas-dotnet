using System;
using System.Collections.Generic;

namespace Infrastructures.Entities
{
    public class Report : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Type { get; set; }
        public Dictionary<string, object> Data { get; set; }
    }
}
