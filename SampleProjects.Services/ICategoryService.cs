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
    public interface ICategoryService
    {
        Task<EntityEntry<Category>> AddAsync(Category item);
        Task<int> AddAndSaveChangesAsync(Category entity);
        Task<int> EditAsync(Category category);
        Task<int> DeleteAsync(Expression<Func<Category, bool>> _pridicate);
        Task<IList<Category>> GetsAsync(Expression<Func<Category, bool>> _pridicate);
        Task<IList<Category>> GetsAsync();
        Task<Category> GetAsync(Expression<Func<Category, bool>> _pridicate);
        Task<Category> FindAsync(Expression<Func<Category, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<Category, bool>> expression);
        Task<bool> AnyAsync();
    }
}
