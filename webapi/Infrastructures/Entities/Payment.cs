using System;

namespace Infrastructures.Entities
{
    public class Payment : BaseEntity
    {
        public Guid SaleId { get; set; }
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public string TransactionId { get; set; }
    }
}
