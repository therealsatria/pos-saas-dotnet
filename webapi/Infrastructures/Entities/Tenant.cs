using System;
using System.Collections.Generic;

namespace Infrastructures.Entities
{
    public class Tenant : BaseEntity
    {
        public string Name { get; set; }
        public string Subdomain { get; set; }
        public Guid PlanId { get; set; }
        
        // Navigation properties
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<AuditLog> AuditLogs { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<PaymentGateway> PaymentGateways { get; set; }
        public ICollection<TenantSetting> TenantSettings { get; set; }
    }
}
