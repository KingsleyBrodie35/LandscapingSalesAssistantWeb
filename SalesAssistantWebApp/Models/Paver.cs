namespace SalesAssistantWebApp.Models
{
    public class Paver
    {
        public int PaverId { get; set; }
        public int typeId { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? supplier { get; set; }
        public string? size { get; set; }
        public bool canCrushRock { get; set; }
        public double price { get; set; }
        public string colour { get; set; }
        public string colourCategory { get; set; }
        public string imagePath { get; set; }

        public Paver(int typeId, string? name, string? description, string? supplier, string? size, bool canCrushRock, double price, string colour, string colourCategory, string imagePath)
        {
            this.typeId = typeId;
            this.name = name;
            this.description = description;
            this.supplier = supplier;
            this.size = size;
            this.canCrushRock = canCrushRock;
            this.price = price;
            this.colour = colour;
            this.colourCategory = colourCategory;
            this.imagePath = imagePath;
        }
    }
}
