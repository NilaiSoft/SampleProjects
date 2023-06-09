﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class ProductService : IProductService
    {
        private readonly IRepository<Product, ProductModel> _productRepository;
        private readonly IPictureService _pictureRepository;
        private readonly IRepository<PictureBinary, ProductPictureModel> _pictureBinaryRepository;
        private readonly IRepository<ProductPicture, ProductPictureModel> _productPictureRepository;

        public ProductService(IRepository<Product, ProductModel> productRepository, IPictureService pictureRepository, IRepository<PictureBinary, ProductPictureModel> pictureBinaryRepository, IRepository<ProductPicture, ProductPictureModel> productPictureRepository)
        {
            _productRepository = productRepository;
            _pictureRepository = pictureRepository;
            _pictureBinaryRepository = pictureBinaryRepository;
            _productPictureRepository = productPictureRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(Product product)
        {
            var insertProduct = await _productRepository.AddAsync(product);
            return await _productRepository.SaveChangesAsync();
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

        public async Task<Product> GetAsync(Expression<Func<Product, bool>> _pridicate, Expression<Func<Product, Product>> selectItem)
        {
            return await _productRepository.GetAsync(_pridicate, selectItem);
        }

        public async Task<int> EditAsync(Product product)
        {
            return await _productRepository.EditAsync(product);
        }
    }
}
