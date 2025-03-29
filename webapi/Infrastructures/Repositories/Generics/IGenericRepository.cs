using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Infrastructures.Repositories;

    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<(IEnumerable<T> Items, int TotalCount)> GetAllAsync(int pageNumber, int pageSize);
        Task<bool> ExistsAsync(Guid id);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task DeleteRangeAsync(IEnumerable<T> entities);
        IQueryable<T> GetQueryable();
    }
