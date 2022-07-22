using Microsoft.EntityFrameworkCore.ChangeTracking;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
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
        Task<int> AddAndSaveChangesAsync(ProductModel model);
        Task<int> EditAsync(ProductModel product);
        Task<int> SaveChangesAsync();
        Task<int> DeleteAsync(Expression<Func<Product, bool>> _pridicate);
        Task<IList<Product>> GetsAsync(Expression<Func<Product, bool>> _pridicate);
        Task<IList<Product>> GetsAsync();
        Task<IList<Product>> GetsAsync(Expression<Func<Product, Product>> expression);
        Task<Product> GetAsync(Expression<Func<Product, bool>> _pridicate);
        Task<Product> GetAsync
            (Expression<Func<Product, bool>> _pridicate, Expression<Func<Product, Product>> selectItem);
        Task<Product> FindAsync(Expression<Func<Product, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<Product, bool>> expression);
        Task<bool> AnyAsync();
    }
}
