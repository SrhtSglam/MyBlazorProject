using project.Shared;

namespace project.Server.Services{
    public interface ICategoryService{
        public List<Category> GetAll();
    }
}