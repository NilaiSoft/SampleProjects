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
        private readonly IMapper _mapper;

        public ProductModelFactory(IUnitService unitService, IMapper mapper)
        {
            _unitService = unitService;
            _mapper = mapper;
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
    }
}
