using mvc_project.DbContexts;
using mvc_project.Entities;

namespace mvc_project.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}