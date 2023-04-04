namespace SalesAssistantWebApp.Models
{
    public class RetainingWall
    {
        public int RetainingWallId { get; set; }
        public int typeId { get; set; }
        public string? name { get; set; }
        public string? size { get; set; }
        public string? description { get; set; }
        public float price { get; set; }
        public int maxHeight { get; set; }
        public bool canCurve { get; set; }
    }
}
