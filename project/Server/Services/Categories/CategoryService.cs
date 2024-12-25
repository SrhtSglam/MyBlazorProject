using System.Net.Http.Json;
using Microsoft.EntityFrameworkCore;
using project.Server.Data;
using project.Shared;

namespace project.Server.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly MainContext _context;

        public CategoryService(MainContext context)
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
            var category = _context.Categories.ToList();
            return category; 
        }
    }
}
