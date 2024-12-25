using project.Shared;

namespace project.Server.Services{
    public interface IProductService{
        public List<Product> GetAll();
    }
}