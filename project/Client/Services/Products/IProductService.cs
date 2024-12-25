using project.Shared;

namespace project.Client.Services{
    public interface IProductService{
        public Task<List<Product>> GetProducts();
    }
}