using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CategoryController
    {
        private CategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }


        [HttpGet("GetInfo")]
        public List<CategoryDto> GetCategory()
        {
            return _categoryService.GetInfoCategory();
        }
         


        [HttpPost("Insert")]
        public int InsertCategory(CategoryDto category)
        {
            return _categoryService.InsertCategory(category);
        }

        [HttpPut("Update")]
        public int UpdateCategory(CategoryDto category)
        {
            return _categoryService.UpdateCategory(category);
        }

        [HttpDelete("Delete")]
        public int DeleteCategory(int id)
        {
            return _categoryService.DeleteCategory(id);
        }         
      

    }

}