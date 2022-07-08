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
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(Product entity)
        {
            return await _productRepository.AddAndSaveChangesAsync(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _productRepository.SaveChangesAsync();
        }

        public async Task<EntityEntry<Product>> AddAsync(Product item)
        {
            return await _productRepository.AddAsync(item);
        }

        public async Task<bool> AnyAsync(Expression<Func<Product, bool>> expression)
        {
            return await _productRepository.AnyAsync(expression);
        }

        public async Task<bool> AnyAsync()
        {
            return await _productRepository.AnyAsync();
        }

        public async Task<int> DeleteAsync(Expression<Func<Product, bool>> _pridicate)
        {
            return await _productRepository.DeleteAsync(_pridicate);
        }

        public async Task<Product> FindAsync(Expression<Func<Product, bool>> predicate)
        {
            return await _productRepository.FindAsync(predicate);
        }

        public async Task<Product> GetAsync(Expression<Func<Product, bool>> _pridicate)
        {
            return await _productRepository.GetAsync(_pridicate);
        }

        public async Task<IList<Product>> GetsAsync(Expression<Func<Product, bool>> _pridicate)
        {
            return await _productRepository.GetsAsync(_pridicate);
        }

        public async Task<IList<Product>> GetsAsync()
        {
            return await _productRepository.GetsAsync(x => new Product
            {
                Id = x.Id,
                Name = x.Name,
                Unit = x.Unit,
                UnitId = x.UnitId,
                Description = x.Description,
                StockQuantity = x.StockQuantity
            });
        }

        public async Task<IList<Product>> GetsAsync(Expression<Func<Product, Product>> expression)
        {
            return await _productRepository.GetsAsync();
        }

        public async Task<int> EditAsync
            (Expression<Func<Product, bool>> predicate, Expression<Func<Product, Product>> expression)
        {
            return await _productRepository.EditAsync(predicate, expression);
        }

        public async Task<Product> GetAsync(Expression<Func<Product, bool>> _pridicate, Expression<Func<Product, Product>> selectItem)
        {
            return await _productRepository.GetAsync(_pridicate, selectItem);
        }
    }
}
