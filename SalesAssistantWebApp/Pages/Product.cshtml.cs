using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SalesAssistantWebApp.Context;
using SalesAssistantWebApp.Models;

namespace SalesAssistantWebApp.Pages
{
    public class ProductModel : PageModel
    {
        private readonly LandscapingAssistantDB _landscapingAssistantDB;
        public Paver? paver;
        public RetainingWall? retainingWall;
        


        public ProductModel(LandscapingAssistantDB landscapingAssistantDB)
        {
            _landscapingAssistantDB = landscapingAssistantDB;
        }

        public void OnGet(string ProductId, string TypeId)
        {
            int pId = 0, tId = 0;
            try
            {
                pId = Int32.Parse(ProductId);
                tId = Int32.Parse(TypeId);
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
            if (TypeId == "0")
            {
                paver = _landscapingAssistantDB.Pavers.Where(p => p.PaverId == pId).First();
            } else
            {
                retainingWall = _landscapingAssistantDB.RetainingWalls.Where(r => r.RetainingWallId == pId).First();
            }
            
        }

       
    }
}
