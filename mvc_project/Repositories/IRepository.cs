﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace mvc_project.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        void AddOrUpdate(T entity);
    }
}
