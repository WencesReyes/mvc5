using mvc_project.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_project.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Name = "Chucky",
                    Category = "Horror",
                    InBillboard = true
                },
                new Movie
                {
                    Id = 2,
                    Name = "The social network",
                    Category = "Based on real life",
                    InBillboard = true
                },
                new Movie
                {
                    Id = 3,
                    Name = "Transformers",
                    Category = "Thriller",
                    InBillboard = false
                },
            };
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            var movies = await GetAllAsync();

            var movie = movies.First(m => m.Id == id);

            return movie;
        }
    }
}