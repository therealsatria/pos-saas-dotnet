namespace Core.Entities
{
    public class Payment : BaseEntity
    {
        public Guid SaleId { get; set; }
        public string Method { get; set; }  // cash/card/ewallet
        public decimal Amount { get; set; }
        public string TransactionId { get; set; }
        
        // Navigation properties
        public Sale Sale { get; set; }
    }
}
