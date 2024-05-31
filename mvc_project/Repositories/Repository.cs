using mvc_project.DbContexts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;

namespace mvc_project.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        protected readonly AppDbContext _appDbContext;

        public Repository(AppDbContext appDbContext)
        {
            _dbSet = appDbContext.Set<T>();
            _appDbContext = appDbContext;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual void AddOrUpdate(T entity)
        {
            _dbSet.AddOrUpdate(entity);
        }
    }
}