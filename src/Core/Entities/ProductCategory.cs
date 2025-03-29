namespace Core.Entities
{
    public class ProductCategory : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }
        
        // Navigation properties
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
