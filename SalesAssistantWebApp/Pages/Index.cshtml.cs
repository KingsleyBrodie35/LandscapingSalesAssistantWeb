using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;
using SalesAssistantWebApp.Context;
using SalesAssistantWebApp.Models;
using Microsoft.Extensions.DependencyInjection;

namespace SalesAssistantWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LandscapingAssistantDB _landscapingAssistantDB;
        public List<RetainingWall>? rWresults;
        public List<Paver>? pResults;
        [BindProperty]
        public string? project_type {get; set; }
        [BindProperty]
        public string? size { get; set; }
        [BindProperty]
        public string? colour { get; set; }
        [BindProperty]
        public bool? isCrushRock { get; set; }
        [BindProperty]
        public bool? canWallCurve { get; set; }
        public int wallHeight { get; set; }

        //inject DbContext into model
        public IndexModel(LandscapingAssistantDB landscapingAssistantDB)
        {
            _landscapingAssistantDB = landscapingAssistantDB;
        }

        public void OnGet()
        {
            _landscapingAssistantDB.createData();
            var p = _landscapingAssistantDB.Pavers.Where(p => p.canCrushRock == true).ToList<Paver>();
        }

        public void OnPost(string wallHeight)
        {
            if(wallHeight != null)
            {
                try
                {
                    wallHeight = wallHeight.Remove(wallHeight.Length - 2);
                    this.wallHeight = Int32.Parse(wallHeight);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            if (project_type == "paver")
            {
                pResults = _landscapingAssistantDB.Pavers.Where(p => p.canCrushRock == isCrushRock && p.size == size && p.colourCategory == colour).ToList<Paver>();
            }
            if (project_type == "retaining Wall")
            {
                rWresults = _landscapingAssistantDB.RetainingWalls.Where(r => r.canCurve == canWallCurve && r.maxHeight > this.wallHeight && r.colourCategory == colour).ToList<RetainingWall>();
            }
        }
    }
}