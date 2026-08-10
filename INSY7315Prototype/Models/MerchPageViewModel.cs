namespace INSY7315Prototype.Models
{
    public class MerchPageViewModel
    {
        public List<MerchItem> Items { get; set; } = new();
    }

    public class MerchItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;   // e.g. "Apparel", "Drinkware", "Accessories"
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? PhotoUrl { get; set; }
        public string? BackPhotoUrl { get; set; }
        public bool IsSoldOut { get; set; }
        public bool IsNew { get; set; }
    }
}