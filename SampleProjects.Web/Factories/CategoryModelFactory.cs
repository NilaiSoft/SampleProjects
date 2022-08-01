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
    public class CategoryModelFactory : ICategoryModelFactory
    {
        private readonly IUnitService _unitService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryModelFactory(IUnitService unitService, IMapper mapper, IProductService productService, ICategoryService categoryService)
        {
            _unitService = unitService;
            _mapper = mapper;
            _productService = productService;
            _categoryService = categoryService;
        }

        public Task<IList<CategoryModel>> PrepareCategoryAsync(IList<Category> categorys)
        {
            var model = _mapper.Map<IList<CategoryModel>>(categorys);
            return Task.FromResult(model);
        }

        public Task<CategoryModel> PrepareCategoryModelAsync(Category category)
        {
            var model = _mapper.Map<CategoryModel>(category);
            return Task.FromResult(model);
        }

        public async Task<CategoryModel> PrepareCategoryModelAsync(int ProductId)
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

            return new CategoryModel
            {

            };
        }
    }
}
