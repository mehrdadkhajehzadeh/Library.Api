namespace Library.Api.Services.Books.DTOs
{
    public class UpdateBookDto
    {
        public string BookTitle { get; set; }
        public int BookInventory { get; set; }
        public DateTime PublishedDateBook { get; set; }
    }
}
