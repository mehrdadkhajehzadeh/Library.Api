using Library.Api.Services.Authors.DTOs;
using Library.Api.Services.Books;
using Library.Api.Services.RentBooks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [Route("api/rentbook")]
    [ApiController]
    public class RentBooksController : ControllerBase
    {
        private readonly IRentBookService _rentBookService;

        public RentBooksController(IRentBookService rentBookService)
        {
            _rentBookService = rentBookService;
        }
        [HttpPost("add-rentBook")]
        public void AddRentBook([FromBody] AddRentBookDto dto)
        {
            _rentBookService.Add(dto);
        }
        [HttpGet("get-all-rentBook")]
        public List<GetAllRentBookDto> GetRentBooks([FromQuery] GetAllRentBookDto dto)
        {
            return _rentBookService.GetAllRentBook(dto);
        }

    }
}
