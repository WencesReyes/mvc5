using mvc_project.Entities;
using mvc_project.Models.Movie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mvc_project.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<Movie> GetByIdAsync(int id);
        Task AddAsync(CreateUpdateMovie model);
        Task UpdateAsync(CreateUpdateMovie model);
    }
}
