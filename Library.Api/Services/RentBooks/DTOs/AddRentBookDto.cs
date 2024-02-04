namespace Library.Api.Services.Authors.DTOs
{
    public class AddRentBookDto
    {
        public DateTime RentDate { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}