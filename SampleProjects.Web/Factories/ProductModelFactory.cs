using AutoMapper;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProjects.Web.Factories
{
    public class ProductModelFactory : IProductModelFactory
    {
        private readonly IUnitService _unitService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductModelFactory(IUnitService unitService, IMapper mapper, IProductService productService)
        {
            _unitService = unitService;
            _mapper = mapper;
            _productService = productService;
        }

        public async Task<IList<ProductModel>> PrepareProductAsync(IList<Product> products)
        {
            var model = _mapper.Map<IList<ProductModel>>(products);
            var unitIds = model.ToList().Select(x => x.UnitId);
            var units = await _unitService.GetsAsync(x => unitIds.Contains(x.Id));

            foreach (var item in model)
            {
                item.UnitName = units.FirstOrDefault(x => x.Id == item.UnitId).Name;
            }

            return model;
        }

        public async Task<ProductModel> PrepareProductModelAsync(ProductModel model, Product product)
        {
            product = await _productService.GetAsync(x => x.Id == product.Id,
                x => new Product
                {
                    Description = x.Description,
                    Id = x.Id,
                    Name = x.Name,
                    StockQuantity = x.StockQuantity,
                    Unit = x.Unit
                });

            return new ProductModel
            {
                Description = product.Description,
                Id = product.Id,
                Name = product.Name,
                StockQuantity = product.StockQuantity,
                UnitId = product.UnitId,
                UnitName = product.Unit.Name
            };
        }

        public async Task<ProductModel> PrepareProductModelAsync(int ProductId)
        {
            var product = await _productService.GetAsync(x => x.Id == ProductId,
                x => new Product
                {
                    Description = x.Description,
                    Id = x.Id,
                    Name = x.Name,
                    StockQuantity = x.StockQuantity,
                    Unit = x.Unit
                });

            return new ProductModel
            {
                Description = product.Description,
                Id = product.Id,
                Name = product.Name,
                StockQuantity = product.StockQuantity,
                UnitId = product.UnitId,
                UnitName = product.Unit.Name
            };
        }
    }
}
