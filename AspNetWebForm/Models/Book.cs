using System;

namespace AspNetWebForm
{
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
}
