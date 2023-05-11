using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreRazorPages.Pages
{
    public class DemoEdit : PageModel
    {
        private readonly ILogger<DemoEdit> _logger;

        public DemoEdit(ILogger<DemoEdit> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
