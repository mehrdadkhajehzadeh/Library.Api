using Library.Api.Mig;
using Library.Api.Models;
using Library.Api.Services.Books.DTOs;

namespace Library.Api.Services.Books
{
    public class BookService:IBookService
    {
        private readonly EFDataContext _dbContext;

        public BookService(EFDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(AddBookDto dto)
        {
            var book = new Book()
            {
                BookTitle = dto.BookTitle,
                BookInventory = dto.BookInventory,
                PublishedDateBook = dto.PublishedDateBook,
                CategoryId = dto.CategoryId,    
                AuthorId = dto.AuthorId,
            };
            _dbContext.books.Add(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _dbContext.books.FirstOrDefault(x => x.Id == id);
            _dbContext.books.Remove(book);
            _dbContext.SaveChanges();
        }

        public List<GetBookDto> GetAllBook(GetBookDto dto)
        {
            return (List<GetBookDto>)_dbContext.books.Select(_ => new GetBookDto()
            {
                Id = dto.Id,
                BookTitle = dto.BookTitle,
                BookInventory = dto.BookInventory,
                PublishedDateBook = dto.PublishedDateBook,
                CategoryId = dto.CategoryId,
                AuthorId = dto.AuthorId,

            }).ToList();
        }

    

        public void UpdateBook(int id, UpdateBookDto dto)
        {
            var book = _dbContext.books.First(_ => _.Id == id);
            book.BookTitle = dto.BookTitle;
            book.BookInventory = dto.BookInventory;
            book.PublishedDateBook = dto.PublishedDateBook;
            _dbContext.SaveChanges();
        }

        public void UpdateBookTitle(int id, UpdateBookTitleDto dto)
        {
            var book = _dbContext.books.First(_ => _.Id == id);
            book.BookTitle = dto.BookTitle;
            _dbContext.SaveChanges();
        }
    }
}
