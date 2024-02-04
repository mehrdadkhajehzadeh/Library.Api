using Library.Api.Services.Authors.DTOs;
using Library.Api.Services.Users.DTOs;

namespace Library.Api.Services.Users
{
    public interface IUserService
    {
        public void Add(AddUserDto dto);
        void Delete(int id);
        public List<GetAllUserDto> GetAllUser(GetAllUserDto dto);
        void Update(int id, UpdateUserDto dto);
    }
}
