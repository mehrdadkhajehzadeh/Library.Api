using Library.Api.Services.Authors.DTOs;
using Library.Api.Services.Authors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library.Api.Services.Categories;

namespace Library.Api.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("add-category")]
        public void AddCategory([FromBody] AddCategoryDto dto)
        {
            _categoryService.Add(dto);
        }
        [HttpPatch("update-category/{id}")]
        public void UpdateCategory([FromRoute] int id, [FromBody] UpdateCategoryDto dto)
        {
            _categoryService.Update(id, dto);
        }

        [HttpDelete("delete-category/{id}")]
        public void DeleteCategory([FromRoute] int id)
        {
            _categoryService.Delete(id);
        }
        [HttpGet("get-all-category")]
        public List<GetAllCategoryDto> GetCategories([FromQuery] GetAllCategoryDto dto)
        {
            return _categoryService.GetAllCategory(dto);
        }
    }
}
