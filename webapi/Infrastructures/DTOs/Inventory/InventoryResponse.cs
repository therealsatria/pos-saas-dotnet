namespace webapi.Infrastructures.DTOs.Inventory
{
    public class InventoryResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Location { get; set; }
        public DateTime LastRestockDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
