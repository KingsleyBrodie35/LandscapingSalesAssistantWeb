using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SalesAssistantWebApp.Context;
using SalesAssistantWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace SalesAssistantWebApp.Pages
{
    public class ProductModel : PageModel
    {
        private readonly LandscapingAssistantDB _landscapingAssistantDB;
        public Paver? paver { get; set; }
        public RetainingWall? retainingWall { get; set; }
        public bool msg;

        private readonly UserManager<IdentityUser> _userManager;

        public ProductModel(LandscapingAssistantDB landscapingAssistantDB, UserManager<IdentityUser> userManager)
        {
            _landscapingAssistantDB = landscapingAssistantDB;
            _userManager = userManager;
        }
        
        public void OnGet(string ProductId, string TypeId)
        {
            int pId = 0, tId = 0;
            try
            {
                pId = Int32.Parse(ProductId);
                tId = Int32.Parse(TypeId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            if (TypeId == "0")
            {
                paver = _landscapingAssistantDB.Pavers.Where(p => p.PaverId == pId).FirstOrDefault();
            }
            else
            {
                retainingWall = _landscapingAssistantDB.RetainingWalls.Where(r => r.RetainingWallId == pId).FirstOrDefault();
            }
        }

        public IActionResult OnPost(string m2, string Lm, string ProductId, string TypeId)
        {
            HttpContext.Session.SetString($"ProductId/{ProductId}", ProductId);
            HttpContext.Session.SetString($"TypeId/{ProductId}", TypeId);
            if (m2 != null)
            {
                HttpContext.Session.SetString($"Amount/{ProductId}", m2);
            }
            if (Lm != null)
            {
                HttpContext.Session.SetString($"Amount/{ProductId}", Lm);
            }

            var routeValues = new RouteValueDictionary();
            routeValues.Add("ProductId", ProductId);
            routeValues.Add("TypeId", TypeId);
            msg = true;
            return RedirectToPage("./Product", routeValues);
        }
    }
}
