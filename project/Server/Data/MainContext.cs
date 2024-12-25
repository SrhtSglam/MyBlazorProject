using Microsoft.EntityFrameworkCore;
using project.Shared;

namespace project.Server.Data{
    public class MainContext : DbContext{
        public MainContext(DbContextOptions<MainContext> options) :base(options){

        }

        public DbSet<Product> Products {get;set;}
    }
}