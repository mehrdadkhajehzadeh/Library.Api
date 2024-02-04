using Library.Api.Services.Authors.DTOs;

namespace Library.Api.Services.Categories
{
    public interface ICategoryService
    {
        public void Add(AddCategoryDto dto);
        void Delete(int id);
        public List<GetAllCategoryDto> GetAllCategory(GetAllCategoryDto dto);
        void Update(int id, UpdateCategoryDto dto);
    }
}
