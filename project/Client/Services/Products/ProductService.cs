using System.Net.Http.Json;
using project.Shared;

namespace project.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory _factory;

        public ProductService(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        public async Task<List<Product>> GetProducts()
        {
            var client = _factory.CreateClient("PublicAPI");
            var product = await client.GetFromJsonAsync<List<Product>>("Product/GetProducts");
            return product; 
        }
    }
}
