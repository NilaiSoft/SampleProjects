using Microsoft.EntityFrameworkCore.ChangeTracking;
using SampleProjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Services
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<EntityEntry<TEntity>> AddAsync(TEntity item);
        Task<int> AddAndSaveChangesAsync(TEntity entity);
        Task<int> UpdateAsync(TEntity item);
        Task<bool> DeleteAsync(TEntity item);
        Task<IList<TEntity>> GetsAsync(Expression<Func<TEntity, bool>> _pridicate);
        Task<IList<TEntity>> GetsAsync();
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> _pridicate);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);
        Task<bool> AnyAsync();
    }
}
