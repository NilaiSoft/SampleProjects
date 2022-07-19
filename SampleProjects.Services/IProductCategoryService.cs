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
    public interface IProductCategoryService
    {
        Task<EntityEntry<ProductCategory>> AddAsync(ProductCategory item);
        Task<int> AddAndSaveChangesAsync(ProductCategory entity);
        Task<int> EditAsync(ProductCategory productCategory);
        Task<int> DeleteAsync(Expression<Func<ProductCategory, bool>> _pridicate);
        Task<IList<ProductCategory>> GetsAsync(Expression<Func<ProductCategory, bool>> _pridicate);
        Task<IList<ProductCategory>> GetsAsync();
        Task<ProductCategory> GetAsync(Expression<Func<ProductCategory, bool>> _pridicate);
        Task<ProductCategory> FindAsync(Expression<Func<ProductCategory, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<ProductCategory, bool>> expression);
        Task<bool> AnyAsync();
    }
}
