using Microsoft.AspNetCore.Mvc;
using project.Server.Services;
using project.Shared;

namespace project.Server.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {

        private readonly ILogger<CategoryController> _logger;
        private ICategoryService _categoryService;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        [HttpGet("GetCategories")]
        public List<Category> GetCategories()
        {
            var categories =  _categoryService.GetAll();
            return categories;
        }
    }
}

