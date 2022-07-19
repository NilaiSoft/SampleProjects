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
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IRepository<ProductCategory, ProductCategoryModel> _productCategoryRepository;

        public ProductCategoryService(IRepository<ProductCategory, ProductCategoryModel> productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(ProductCategory entity)
        {
            return await _productCategoryRepository.AddAndSaveChangesAsync(entity);
        }

        public async Task<EntityEntry<ProductCategory>> AddAsync(ProductCategory item)
        {
            return await _productCategoryRepository.AddAsync(item);
        }

        public async Task<bool> AnyAsync(Expression<Func<ProductCategory, bool>> expression)
        {
            return await _productCategoryRepository.AnyAsync(expression);
        }

        public async Task<bool> AnyAsync()
        {
            return await _productCategoryRepository.AnyAsync();
        }

        public async Task<int> DeleteAsync(Expression<Func<ProductCategory, bool>> _pridicate)
        {
            return await _productCategoryRepository.DeleteAsync(_pridicate);
        }

        public async Task<ProductCategory> FindAsync(Expression<Func<ProductCategory, bool>> predicate)
        {
            return await _productCategoryRepository.FindAsync(predicate);
        }

        public async Task<ProductCategory> GetAsync(Expression<Func<ProductCategory, bool>> _pridicate)
        {
            return await _productCategoryRepository.GetAsync(_pridicate);
        }

        public async Task<IList<ProductCategory>> GetsAsync(Expression<Func<ProductCategory, bool>> _pridicate)
        {
            return await _productCategoryRepository.GetsAsync(_pridicate);
        }

        public async Task<IList<ProductCategory>> GetsAsync()
        {
            return await _productCategoryRepository.GetsAsync();
        }

        public async Task<int> EditAsync(ProductCategory productCategory)
        {
            return await _productCategoryRepository.EditAsync(productCategory);
        }
    }
}
