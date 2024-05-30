using mvc_project.Entities;
using mvc_project.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mvc_project.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return await _movieRepository.GetAllAsync();
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            return await _movieRepository.GetByIdAsync(id);
        }
    }
}