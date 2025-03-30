using System;

namespace Infrastructures.Entities
{
    public class LoyaltyPoint : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Guid LoyaltyProgramId { get; set; }
        public int Balance { get; set; }
        
        // Navigation properties
        public Customer Customer { get; set; }
        public LoyaltyProgram LoyaltyProgram { get; set; }
    }
}
