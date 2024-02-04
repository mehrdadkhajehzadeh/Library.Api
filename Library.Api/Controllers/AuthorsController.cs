using Library.Api.Services.Books.DTOs;
using Library.Api.Services.Books;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library.Api.Services.Authors;
using Library.Api.Services.Authors.DTOs;

namespace Library.Api.Controllers
{
    [Route("api/author")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost("add-author")]
        public void AddAuthor([FromBody] AddAuthorDto dto)
        {
            _authorService.Add(dto);
        }
        [HttpPatch("update-title/{id}")]
        public void UpdateAuthor([FromRoute] int id, [FromBody] UpdateAuthorDto dto)
        {
            _authorService.Update(id, dto);
        }
      
        [HttpDelete("delete-author/{id}")]
        public void DeleteAuthor([FromRoute] int id)
        {
            _authorService.Delete(id);
        }
        [HttpGet("get-all-author")]
        public List<GetAllAuthorDto> GetAuthors([FromQuery] GetAllAuthorDto dto)
        {
            return _authorService.GetAllAuthor(dto);
        }
    }
}
