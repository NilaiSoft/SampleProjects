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
    public class ProductPictureService : IProductPictureService
    {
        private readonly IRepository<ProductPicture, ProductPictureModel> _productPictureRepository;

        public ProductPictureService(IRepository<ProductPicture, ProductPictureModel> productPictureRepository)
        {
            _productPictureRepository = productPictureRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(ProductPicture entity)
        {
            return await _productPictureRepository.AddAndSaveChangesAsync(entity);
        }

        public async Task<EntityEntry<ProductPicture>> AddAsync(ProductPicture item)
        {
            return await _productPictureRepository.AddAsync(item);
        }

        public async Task<bool> AnyAsync(Expression<Func<ProductPicture, bool>> expression)
        {
            return await _productPictureRepository.AnyAsync(expression);
        }

        public async Task<bool> AnyAsync()
        {
            return await _productPictureRepository.AnyAsync();
        }

        public async Task<int> DeleteAsync(Expression<Func<ProductPicture, bool>> _pridicate)
        {
            return await _productPictureRepository.DeleteAsync(_pridicate);
        }

        public async Task<ProductPicture> FindAsync(Expression<Func<ProductPicture, bool>> predicate)
        {
            return await _productPictureRepository.FindAsync(predicate);
        }

        public async Task<ProductPicture> GetAsync(Expression<Func<ProductPicture, bool>> _pridicate)
        {
            return await _productPictureRepository.GetAsync(_pridicate);
        }

        public async Task<IList<ProductPicture>> GetsAsync(Expression<Func<ProductPicture, bool>> _pridicate)
        {
            return await _productPictureRepository.GetsAsync(_pridicate);
        }

        public async Task<IList<ProductPicture>> GetsAsync()
        {
            return await _productPictureRepository.GetsAsync();
        }

        public async Task<int> EditAsync(ProductPicture productPicture)
        {
            return await _productPictureRepository.EditAsync(productPicture);
        }
    }
}
