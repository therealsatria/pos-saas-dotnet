using Microsoft.EntityFrameworkCore;
using webapi.Infrastructures.Data;
using webapi.Infrastructures.Exceptions;
using webapi.Infrastructures.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructures.Repositories;

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity ?? throw new NotFoundException($"{typeof(T).Name} with Id {id} not found");
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<(IEnumerable<T> Items, int TotalCount)> GetAllAsync(int pageNumber, int pageSize)
        {
            var totalCount = await _dbSet.CountAsync();
            var items = await _dbSet.Skip((pageNumber - 1) * pageSize)
                                  .Take(pageSize)
                                  .ToListAsync();
            return (items, totalCount);
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _dbSet.FindAsync(id) != null;
        }

        public async Task AddAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new ApiException($"Failed to add {typeof(T).Name}: {ex.Message}", ex, 500);
            }
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            try
            {
                await _dbSet.AddRangeAsync(entities);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new ApiException($"Failed to add {typeof(T).Name} range: {ex.Message}", ex, 500);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new ApiException($"Failed to update {typeof(T).Name}: {ex.Message}", ex, 500);
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
                throw new NotFoundException($"{typeof(T).Name} with Id {id} not found");

            try
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new ApiException($"Failed to delete {typeof(T).Name}: {ex.Message}", ex, 500);
            }
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            try
            {
                _dbSet.RemoveRange(entities);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new ApiException($"Failed to delete {typeof(T).Name} range: {ex.Message}", ex, 500);
            }
        }

        public IQueryable<T> GetQueryable()
        {
            return _dbSet.AsQueryable();
        }
    }
