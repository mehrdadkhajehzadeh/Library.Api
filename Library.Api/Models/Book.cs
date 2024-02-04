namespace Library.Api.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public int BookInventory { get; set; }
        public DateTime PublishedDateBook { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public HashSet<RentBook> RentBooks { get; set; }

    }
}
