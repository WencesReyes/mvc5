using System.Threading;
using System.Threading.Tasks;

namespace mvc_project.DbContexts
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
