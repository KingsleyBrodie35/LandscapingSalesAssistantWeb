namespace SalesAssistantWebApp.Models
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int totalProduct { get; set; }
        public double totalValue { get; set; }
        public int totalAmount { get; set; }
        public CartLine(Product product, int totalProduct, double totalValue, int totalAmount)
        {
            Product = product;
            this.totalProduct = totalProduct;
            this.totalValue = totalValue;
            this.totalAmount = totalAmount;
        }
    }
}
