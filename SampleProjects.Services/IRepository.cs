using Microsoft.EntityFrameworkCore;
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
    public interface IRepository<TEntity,TVModel> where TEntity : BaseEntity
    {
        Task<EntityEntry<TEntity>> AddAsync(TEntity item);
        Task AddRangeAsync(IList<TEntity> items);
        Task<int> AddAndSaveChangesAsync(TEntity entity);
        Task<int> AddRangeAndSaveChangesAsync(IList<TEntity> entitys);
        Task<int> SaveChangesAsync();

        #region EditUseZEntity
        //Task<int> EditAsync(Expression<Func<TEntity, bool>> predicate,
        //    Expression<Func<TEntity, TEntity>> expression);
        #endregion

        Task<int> EditAsync(TEntity entity);

        Task<int> EditAsync(Expression<Func<TEntity, TEntity>> predicate
            , Expression<Func<TEntity, TEntity>> entity);

        Task<TEntity> GetAsync
            (Expression<Func<TEntity, bool>> _pridicate, Expression<Func<TEntity, TEntity>> selectItem);
        Task<int> DeleteAsync(Expression<Func<TEntity, bool>> _pridicate);
        Task<IList<TEntity>> GetsAsync(Expression<Func<TEntity, bool>> _pridicate);
        Task<IList<TEntity>> GetsAsync
            (Expression<Func<TEntity, bool>> _pridicate,
            Expression<Func<TEntity, TEntity>> selectList);
        Task<IList<TEntity>> GetsAsync();
        Task<IList<TEntity>> GetsAsync(Expression<Func<TEntity, TEntity>> selectList);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> _pridicate);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);
        Task<bool> AnyAsync();
    }
}
