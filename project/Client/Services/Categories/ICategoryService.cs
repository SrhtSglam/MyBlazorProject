using project.Shared;

namespace project.Client.Services{
    public interface ICategoryService{
        public Task<List<Category>> GetCategories();
        public Task<List<SubCategory>> GetSubCategories();
    }
}