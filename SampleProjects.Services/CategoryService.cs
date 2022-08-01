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
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category, CategoryModel> _categoryRepository;

        public CategoryService(IRepository<Category, CategoryModel> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(Category entity)
        {
            return await _categoryRepository.AddAndSaveChangesAsync(entity);
        }

        public async Task<EntityEntry<Category>> AddAsync(Category item)
        {
            return await _categoryRepository.AddAsync(item);
        }

        public async Task<bool> AnyAsync(Expression<Func<Category, bool>> expression)
        {
            return await _categoryRepository.AnyAsync(expression);
        }

        public async Task<bool> AnyAsync()
        {
            return await _categoryRepository.AnyAsync();
        }

        public async Task<int> DeleteAsync(Expression<Func<Category, bool>> _pridicate)
        {
            return await _categoryRepository.DeleteAsync(_pridicate);
        }

        public async Task<Category> FindAsync(Expression<Func<Category, bool>> predicate)
        {
            return await _categoryRepository.FindAsync(predicate);
        }

        public async Task<Category> GetAsync(Expression<Func<Category, bool>> _pridicate)
        {
            return await _categoryRepository.GetAsync(_pridicate);
        }

        public async Task<IList<Category>> GetsAsync(Expression<Func<Category, bool>> _pridicate)
        {
            return await _categoryRepository.GetsAsync(_pridicate);
        }

        public async Task<IList<Category>> GetsAsync()
        {
            return await _categoryRepository.GetsAsync();
        }

        public async Task<int> EditAsync(Category category)
        {
            return await _categoryRepository.EditAsync(category);
        }
    }
}
