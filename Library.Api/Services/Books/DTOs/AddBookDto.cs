namespace Library.Api.Services.Books.DTOs
{
    public class AddBookDto
    {
        public string BookTitle { get; set; }
        public int BookInventory { get; set; }
        public DateTime PublishedDateBook { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}