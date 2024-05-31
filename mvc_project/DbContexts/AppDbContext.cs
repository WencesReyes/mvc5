using mvc_project.Entities;
using System.Data.Entity;

namespace mvc_project.DbContexts
{
    public class AppDbContext : DbContext, IUnitOfWork
    {
        public AppDbContext() : base("ApplicationConnectionString")
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
    }
}