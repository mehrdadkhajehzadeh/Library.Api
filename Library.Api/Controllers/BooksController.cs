using Library.Api.Services.Books;
using Library.Api.Services.Books.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("add-book")]
        public void AddBook([FromBody]AddBookDto dto)
        {
            _bookService.Add(dto);
        }
        [HttpPatch("update-title/{id}")]
        public void UpdateBookTitle([FromRoute]int id,[FromBody]UpdateBookTitleDto dto)
        {
            _bookService.UpdateBookTitle(id, dto);
        }
        [HttpPatch("update-book/{id}")]
        public void UpdateBook([FromRoute] int id, [FromBody] UpdateBookDto dto)
        {
            _bookService.UpdateBook(id, dto);
        }
        [HttpDelete("delete-book/{id}")]
        public void DeleteBook([FromRoute] int id)
        {
            _bookService.DeleteBook(id);
        }
        [HttpGet("get-all-book")]
        public List<GetBookDto> GetBooks([FromQuery] GetBookDto dto)
        {
           return _bookService.GetAllBook(dto);
        }
    }
}
