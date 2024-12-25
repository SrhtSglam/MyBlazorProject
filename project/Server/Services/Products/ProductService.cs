using System.Net.Http.Json;
using Microsoft.EntityFrameworkCore;
using project.Server.Data;
using project.Shared;

namespace project.Server.Services
{
    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory _factory;
        private readonly MainContext _context;

        public ProductService(MainContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            var product = _context.Products.ToList();
            return product; 
        }
    }
}
