using System;

namespace Infrastructures.Entities
{
    public class LoyaltyPoint : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public int Balance { get; set; }
    }
}
