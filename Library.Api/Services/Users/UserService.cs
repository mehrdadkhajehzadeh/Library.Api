using Library.Api.Mig;
using Library.Api.Models;
using Library.Api.Services.Users.DTOs;

namespace Library.Api.Services.Users
{
    public class UserService : IUserService
    {
        private readonly EFDataContext _dbContext;

        public UserService(EFDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(AddUserDto dto)
        {
            var user = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                RentBookId = dto.RentBookId,
            };
            _dbContext.users.Add(user);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _dbContext.users.FirstOrDefault(x => x.Id == id);
            _dbContext.users.Remove(user);
            _dbContext.SaveChanges();
        }

        public List<GetAllUserDto> GetAllUser(GetAllUserDto dto)
        {
            return _dbContext.users.Select(_ => new GetAllUserDto()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
            }).ToList();
        }

        public void Update(int id, UpdateUserDto dto)
        {
            var user = _dbContext.users.FirstOrDefault(_ => _.Id == id);
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;

        }
    }
}
