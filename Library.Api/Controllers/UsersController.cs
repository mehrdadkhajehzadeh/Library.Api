using Library.Api.Services.Authors.DTOs;
using Library.Api.Services.Books;
using Library.Api.Services.Users;
using Library.Api.Services.Users.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        [HttpPost("add-user")]
        public void AddUser(AddUserDto dto)
        {
            _userService.Add(dto);
        }
        [HttpPatch("update-user/{id}")]
        public void UpdateUser([FromRoute] int id, [FromBody] UpdateUserDto dto)
        {
            _userService.Update(id, dto);
        }

        [HttpDelete("delete-user/{id}")]
        public void DeleteUser([FromRoute] int id)
        {
            _userService.Delete(id);
        }
        [HttpGet("get-all-user")]
        public List<GetAllUserDto> GetCategories([FromQuery] GetAllUserDto dto)
        {
            return _userService.GetAllUser(dto);
        }
    }
}
