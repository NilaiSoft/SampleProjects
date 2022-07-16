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
    public interface IStateProvinceService
    {
        Task<EntityEntry<StateProvince>> AddAsync(StateProvince item);
        Task<int> AddAndSaveChangesAsync(StateProvince entity);
        Task<int> SaveChangesAsync();
        Task<int> DeleteAsync(Expression<Func<StateProvince, bool>> _pridicate);
        Task<IList<StateProvince>> GetsAsync(Expression<Func<StateProvince, bool>> _pridicate);
        Task<IList<StateProvince>> GetsAsync();
        Task<IList<StateProvince>> GetsAsync(Expression<Func<StateProvince, StateProvince>> expression);
        Task<StateProvince> GetAsync(Expression<Func<StateProvince, bool>> _pridicate);
        Task<StateProvince> GetAsync
            (Expression<Func<StateProvince, bool>> _pridicate, Expression<Func<StateProvince, StateProvince>> selectItem);
        Task<StateProvince> FindAsync(Expression<Func<StateProvince, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<StateProvince, bool>> expression);
        Task<bool> AnyAsync();
    }
}
