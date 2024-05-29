using mvc_project.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mvc_project.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllAsync();
    }
}
