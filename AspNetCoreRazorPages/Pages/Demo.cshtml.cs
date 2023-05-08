using System.Text.Json;
using AspNetCoreRazorPages.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreRazorPages.Pages
{
    public class Demo : PageModel
    {
        private readonly ILogger<Demo> _logger;
        private readonly BookService   _bookService;

        public Demo(ILogger<Demo> logger,
                    BookService   bookService)
        {
            _logger      = logger;
            _bookService = bookService;
        }

        public void OnGet()
        {
            var books = _bookService.GetBooks();
            ViewData["books"] = JsonSerializer.Serialize(books);
        }
    }
}
