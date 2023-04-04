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
        public float price { get; set; }
    }
}
