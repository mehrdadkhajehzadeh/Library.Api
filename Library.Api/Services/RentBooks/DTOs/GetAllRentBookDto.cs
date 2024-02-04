namespace Library.Api.Services.Authors.DTOs
{
    public class GetAllRentBookDto
    {
        public int Id { get; set; }
        public DateTime RentDate { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }


    }
}
