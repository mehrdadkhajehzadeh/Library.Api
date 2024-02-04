using Library.Api.Mig;
using Library.Api.Models;
using Library.Api.Services.Authors.DTOs;

namespace Library.Api.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly EFDataContext _dbContext;

        public CategoryService(EFDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(AddCategoryDto dto)
        {
            var category = new Category()
            {
                 CategoryName = dto.CategoryName,
            };
            _dbContext.categories.Add(category);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _dbContext.categories.FirstOrDefault(_ => _.Id == id);
            _dbContext.categories.Remove(category);
            _dbContext.SaveChanges();
        }

        public List<GetAllCategoryDto> GetAllCategory(GetAllCategoryDto dto)
        {
            return _dbContext.categories.Select(_ => new GetAllCategoryDto()
            {
                CategoryName = dto.CategoryName,
                Id = dto.Id

            }).ToList();
        }

        public void Update(int id, UpdateCategoryDto dto)
        {
            var category = _dbContext.categories.FirstOrDefault(_ => _.Id == id);
            category.CategoryName= dto.CategoryName;
        }
    }
}
