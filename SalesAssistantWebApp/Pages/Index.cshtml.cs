using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;


namespace SalesAssistantWebApp.Pages
{
    public class IndexModel : PageModel
    {
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
        [BindProperty]
        public string? wallHeight { get; set; }


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            Console.WriteLine("hello");
        }
    }
}