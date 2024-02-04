using Library.Api.Mig;
using Library.Api.Models;
using Library.Api.Services.Authors.DTOs;

namespace Library.Api.Services.RentBooks
{
    public class RentBookService : IRentBookService
    {
        private readonly EFDataContext _dbContext;

        public RentBookService(EFDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(AddRentBookDto dto)
        {
            var rentBook = new RentBook()
            {
                BookId = dto.BookId,
                UserId = dto.UserId,
                RentDate = dto.RentDate,
            };
            _dbContext.rentBooks.Add(rentBook);
            _dbContext.SaveChanges();
        }

        public List<GetAllRentBookDto> GetAllRentBook(GetAllRentBookDto dto)
        {
            return _dbContext.rentBooks.Select(_ => new GetAllRentBookDto()
            {
                BookId = dto.BookId,
                UserId = dto.UserId,
                RentDate = dto.RentDate,
                Id = dto.Id

            }).ToList();
        }
    }
}
