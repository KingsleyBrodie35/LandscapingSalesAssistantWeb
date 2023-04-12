using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SalesAssistantWebApp.Context;
using SalesAssistantWebApp.Models;

namespace SalesAssistantWebApp.Pages
{
    public class CartModel : PageModel
    {
        private readonly LandscapingAssistantDB _landscapingAssistantDB;
        public List<CartLine> cartLines = new List<CartLine>();


        public CartModel(LandscapingAssistantDB landscapingAssistantDB)
        {
            _landscapingAssistantDB = landscapingAssistantDB;
        }

        public void OnGet()
        {
            List<string?> vals = new List<string?>();
            if (HttpContext.Session.Keys != null)
            {
                foreach (var key in HttpContext.Session.Keys)
                {
                    vals.Add(HttpContext.Session.GetString(key));
                }
                FindProducts(vals);
            }
        }

        private void FindProducts(List<string?> vals)
        {
            while (vals.Count != 0)
            {
                List<string> singleSessionInfo = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    singleSessionInfo.Add(vals[i]);
                }
                //do actions with single session info
                int productId = 0, typeId = 0, amount = 0;
                try
                {
                    productId = Int32.Parse(singleSessionInfo[0]);
                    typeId = Int32.Parse(singleSessionInfo[1]);
                    amount = Int32.Parse(singleSessionInfo[2]);
                } catch (Exception e){ Console.WriteLine(e); }

                //add to Cartlines
                if (typeId == 0)
                {
                    //find product
                    Paver? p = _landscapingAssistantDB.Pavers.Where(p => p.PaverId == productId).FirstOrDefault();
                    //calculate values    
                    string[] dimensions = p.size.Split("x");
                    
                    int length = 0, width = 0;
                    try
                    {
                        length = Int32.Parse(dimensions[0]);
                        width = Int32.Parse(dimensions[1]);
                    }
                    catch (Exception e) { Console.WriteLine(e); }
                    int totalProduct = 1000 / length * 1000 / width * amount;
                    double totalValue = totalProduct * p.price;
                    cartLines.Add(new CartLine(p, totalProduct, totalValue, amount));
                }
                if (typeId == 1)
                {
                    //find product
                    RetainingWall? rw = _landscapingAssistantDB.RetainingWalls.Where(r => r.RetainingWallId == productId).FirstOrDefault();
                    int length = 0;
                    string[] dimensions = rw.size.Split("x");
                    try
                    {
                        length = Int32.Parse(dimensions[0]);
                    }
                    catch (Exception e) { Console.WriteLine(e); }
                    int totalProduct = 1000 / length * amount;
                    double totalValue = totalProduct * rw.price;
                    cartLines.Add(new CartLine(rw, totalProduct, totalValue, amount));
                }


                //remove singleSessionInfo from vals
                vals.RemoveAt(0);
                vals.RemoveAt(0);
                vals.RemoveAt(0);
            }
        }
    }
}
