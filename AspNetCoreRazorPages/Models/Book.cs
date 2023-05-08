namespace AspNetCoreRazorPages.Models;

/// <summary>
/// 資料表 Book
/// </summary>
public class Book
{
    public Guid Id { get; set; }
        
    public string Title { get; set; }
        
    public string Author { get; set; }
        
    public string Genre { get; set; }
        
    public decimal Price { get; set; }
        
    public DateTime PublishDate { get; set; }

    public bool Editable { get; set; }
        
    public bool Deletable { get; set; }
}


/// <summary>
/// 顯示用 Dto
/// </summary>
public class BookDto : Book
{
    public string PriceText { get; set; }

    public string PublishDateText { get; set; }
}
