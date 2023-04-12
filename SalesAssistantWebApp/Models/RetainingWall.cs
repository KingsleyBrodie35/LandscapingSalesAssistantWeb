namespace SalesAssistantWebApp.Models
{
    public class RetainingWall : Product
    {
        public int RetainingWallId { get; set; }
        public int typeId { get; set; }
        public string? name { get; set; }
        public string? size { get; set; }
        public string? description { get; set; }
        public double price { get; set; }
        public int maxHeight { get; set; }
        public bool canCurve { get; set; }
        public string? colour { get; set; }
        public string? colourCategory { get; set; }
        public string? imagePath { get; set; }
        public RetainingWall(int typeId, string? name, string? size, string? description, double price, int maxHeight, bool canCurve, string? colour, string? colourCategory, string? imagePath)
        {
            this.typeId = typeId;
            this.name = name;
            this.size = size;
            this.description = description;
            this.price = price;
            this.maxHeight = maxHeight;
            this.canCurve = canCurve;
            this.colour = colour;
            this.colourCategory = colourCategory;
            this.imagePath = imagePath;
        }
    }
}
