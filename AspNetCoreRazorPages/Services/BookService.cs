using AspNetCoreRazorPages.Models;

namespace AspNetCoreRazorPages.Services;

public class BookService
{
    /// <summary>
    /// 假設資料從 Dapper 取出
    /// </summary>
    public BookDto[] GetBooks()
    {
        // 產生 10 筆資料
        return Enumerable.Range(1, 10)
                         .Select(i =>
                                 {
                                     var book = new BookDto();
                                     book.Id        = Guid.NewGuid();
                                     book.Title     = $"Title {i}";
                                     book.Author    = $"Author {i}";
                                     book.Genre     = $"Genre {i}";
                                     book.Price     = i * 10;
                                     book.PriceText = book.Price.ToString("0.0");

                                     book.PublishDate     = DateTime.Now.AddDays(i);
                                     book.PublishDateText = book.PublishDate.ToString("yyyy-MM-dd");

                                     book.Editable  = i % 2 == 0;
                                     book.Deletable = i % 3 == 0;

                                     return book;
                                 })
                         .ToArray();
    }
}
