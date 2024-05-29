using mvc_project.Entities;
using System.Collections.Generic;
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
                    Name = "Chucky",
                    Category = "Horror",
                    InBillboard = true
                },
                new Movie
                {
                    Name = "The social network",
                    Category = "Based on real life",
                    InBillboard = true
                },
                new Movie
                {
                    Name = "Transformers",
                    Category = "Thriller",
                    InBillboard = false
                },
            };
        }
    }
}