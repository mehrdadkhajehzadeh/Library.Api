using Library.Api.Services.Authors.DTOs;
using Library.Api.Services.Books.DTOs;

namespace Library.Api.Services.Authors
{
    public interface IAuthorService
    {
        public void Add(AddAuthorDto dto);
        void Delete(int id);
        public List<GetAllAuthorDto> GetAllAuthor(GetAllAuthorDto dto);
        void Update(int id, UpdateAuthorDto dto);
    }
}
