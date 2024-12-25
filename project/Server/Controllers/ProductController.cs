using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using project.Server.Services;
using project.Shared;

namespace project.Server.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] ImageUrls = new[] 
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProductController> _logger;
        private IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Product> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Product
            {
                Name = "Serhat Sağlam",
                ImageUrl = ImageUrls[Random.Shared.Next(ImageUrls.Length)]
            })
            .ToArray();
        }
        [HttpGet("GetProducts")]
        public List<Product> GetProducts()
        {
            var products =  _productService.GetAll();
            return products;
        }
    }
}

