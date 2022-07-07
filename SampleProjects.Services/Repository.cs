using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using SampleProjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Services
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected ApplicationDbContext _context;
        internal DbSet<TEntity> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<int> AddAndSaveChangesAsync(TEntity entity)
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<EntityEntry<TEntity>> AddAsync(TEntity item)
        {
            return await _dbSet.AddAsync(item);
        }

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.AnyAsync(expression);
        }
        public Task<bool> AnyAsync()
        {
            return _dbSet.AnyAsync();
        }

        public async Task<bool> DeleteAsync(TEntity item)
        {
            try
            {
                var exist = await _dbSet.Where(x => x.Id == item.Id)
                                        .FirstOrDefaultAsync();

                if (exist == null) return false;

                _dbSet.Remove(exist);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> _pridicate)
        {
            return await _dbSet.FindAsync(_pridicate);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> _pridicate)
        {
            return await _dbSet.FirstOrDefaultAsync(_pridicate);
        }

        public async Task<IList<TEntity>> GetsAsync(Expression<Func<TEntity, bool>> _pridicate)
        {
            return await _dbSet.Where(_pridicate).ToListAsync();
        }

        public async Task<IList<TEntity>> GetsAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public Task<int> UpdateAsync(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
