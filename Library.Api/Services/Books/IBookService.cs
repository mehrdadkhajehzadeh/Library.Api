using Library.Api.Services.Books.DTOs;

namespace Library.Api.Services.Books
{
    public interface IBookService
    {
        public void Add(AddBookDto dto);
        void DeleteBook(int id);
        public List<GetBookDto> GetAllBook(GetBookDto dto);
        void UpdateBook(int id, UpdateBookDto dto);
        void UpdateBookTitle(int id, UpdateBookTitleDto dto);
    }
}
