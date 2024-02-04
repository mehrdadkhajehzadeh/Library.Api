namespace Library.Api.Models
{
    public class RentBook
    {
        public int Id { get; set; }
        public DateTime RentDate { get; set; }

        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
