using System.Net.Http.Json;
using project.Shared;

namespace project.Client.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IHttpClientFactory _factory;

        public CategoryService(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        public async Task<List<Category>> GetCategories()
        {
            var client = _factory.CreateClient("PublicAPI");
            var category = await client.GetFromJsonAsync<List<Category>>("Category/GetCategories");
            return category; 
        }
        
        public async Task<List<SubCategory>> GetSubCategories()
        {
            var client = _factory.CreateClient("PublicAPI");
            var subcategory = await client.GetFromJsonAsync<List<SubCategory>>("Category/GetSubCategories");
            return subcategory; 
        }
    }
}
