using Library.Api.Services.Authors.DTOs;

namespace Library.Api.Services.RentBooks
{
    public interface IRentBookService
    {
        public void Add(AddRentBookDto dto);
        public List<GetAllRentBookDto> GetAllRentBook(GetAllRentBookDto dto);
    }
}
