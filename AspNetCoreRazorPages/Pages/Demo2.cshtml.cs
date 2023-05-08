using AspNetCoreRazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreRazorPages.Pages
{
    public class Demo2 : PageModel
    {
        private readonly ILogger<Demo2> _logger;
        private readonly BookService    _bookService;

        public Demo2(ILogger<Demo2> logger,
                     BookService    bookService)
        {
            _logger      = logger;
            _bookService = bookService;
        }

        public IActionResult OnPostGetBooks()
        {
            var books = _bookService.GetBooks();
            return new JsonResult(books);
        }
    }
}
