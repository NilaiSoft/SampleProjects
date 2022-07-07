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
    public interface IProductService
    {
        Task<EntityEntry<Product>> AddAsync(Product item);
        Task<int> AddAndSaveChangesAsync(Product entity);
        Task<int> UpdateAsync(Product item);
        Task<bool> DeleteAsync(Product item);
        Task<IList<Product>> GetsAsync(Expression<Func<Product, bool>> _pridicate);
        Task<IList<Product>> GetsAsync();
        Task<Product> GetAsync(Expression<Func<Product, bool>> _pridicate);
        Task<Product> FindAsync(Expression<Func<Product, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<Product, bool>> expression);
        Task<bool> AnyAsync();
    }
}
