namespace TechStoreInventory.Models
{
    public class Products
    {
        public Guid Id { get; set; }
        public required string Product { get; set; }
        public required int Amount { get; set; }
        public string? Type { get; set; }
        public decimal? Price { get; set; }
    }
}
