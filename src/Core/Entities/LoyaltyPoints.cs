namespace Core.Entities
{
    public class LoyaltyPoints : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public int Balance { get; set; }
        
        // Navigation properties
        public Customer Customer { get; set; }
    }
}
