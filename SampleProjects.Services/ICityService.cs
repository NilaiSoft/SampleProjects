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
    public interface ICityService
    {
        Task<EntityEntry<City>> AddAsync(City item);
        Task<int> AddAndSaveChangesAsync(City entity);
        Task<int> EditAsync(City city);
        Task<int> DeleteAsync(Expression<Func<City, bool>> _pridicate);
        Task<IList<City>> GetsAsync(Expression<Func<City, bool>> _pridicate);
        Task<IList<City>> GetsAsync();
        Task<City> GetAsync(Expression<Func<City, bool>> _pridicate);
        Task<City> FindAsync(Expression<Func<City, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<City, bool>> expression);
        Task<bool> AnyAsync();
    }
}
