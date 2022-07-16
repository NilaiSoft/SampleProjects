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
    public interface IUnitService
    {
        Task<EntityEntry<Unit>> AddAsync(Unit item);
        Task<int> AddAndSaveChangesAsync(Unit entity);
        Task<int> EditAsync(Unit unit);
        Task<int> DeleteAsync(Expression<Func<Unit, bool>> _pridicate);
        Task<IList<Unit>> GetsAsync(Expression<Func<Unit, bool>> _pridicate);
        Task<IList<Unit>> GetsAsync();
        Task<Unit> GetAsync(Expression<Func<Unit, bool>> _pridicate);
        Task<Unit> FindAsync(Expression<Func<Unit, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<Unit, bool>> expression);
        Task<bool> AnyAsync();
    }
}
