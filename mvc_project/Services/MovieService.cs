using mvc_project.DbContexts;
using mvc_project.Entities;
using mvc_project.Models.Movie;
using mvc_project.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mvc_project.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IUnitOfWork _unitOfWork;

        public MovieService(
            IMovieRepository movieRepository,
            IUnitOfWork unitOfWork)
        {
            _movieRepository = movieRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return await _movieRepository.GetAllAsync();
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            return await _movieRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(CreateUpdateMovie model)
        {
            var movie = Movie.Create(
                model.Name,
                model.Category,
                model.InBillboard);
            
            _movieRepository.AddOrUpdate(movie);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(CreateUpdateMovie model)
        {
            var movie = await GetByIdAsync(model.Id.Value);

            movie.Update(
                model.Name,
                model.Category,
                model.InBillboard);

            _movieRepository.AddOrUpdate(movie);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}