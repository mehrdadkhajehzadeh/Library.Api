using Library.Api.Mig;
using Library.Api.Models;
using Library.Api.Services.Authors.DTOs;

namespace Library.Api.Services.Authors
{
    public class AuthorService : IAuthorService
    {
        private readonly EFDataContext _dbContext;

        public AuthorService(EFDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(AddAuthorDto dto)
        {
            var author = new Author()
            {
                FullName = dto.FullName,
            };
            _dbContext.authors.Add(author);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var author = _dbContext.authors.FirstOrDefault(_ => _.Id == id);
            _dbContext.authors.Remove(author);
            _dbContext.SaveChanges();
        }

        public List<GetAllAuthorDto> GetAllAuthor(GetAllAuthorDto dto)
        {
            return _dbContext.authors.Select(_ => new GetAllAuthorDto()
            {
                FullName = dto.FullName,    
                Id = dto.Id

            }).ToList();
        }

        public void Update(int id, UpdateAuthorDto dto)
        {
            var author = _dbContext.authors.FirstOrDefault(_ => _.Id == id);
            author.FullName = dto.FullName;
        }
    }
}
