namespace Library.Api.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public HashSet<Book> Books { get; set; }

    }
}
