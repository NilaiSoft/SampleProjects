using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services;
using SampleProjects.Web.BaseController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProjects.Web.Controllers
{
    public class UnitController : BaseController<Unit, UnitModel>
    {
        private readonly IProductService _productService;
        private readonly IUnitService _unitService;

        public UnitController(IProductService productService,
            IUnitService unitService, IMapper mapper, IRepository<Unit, UnitModel> repository)
            : base(repository, mapper)
        {
            _productService = productService;
            _unitService = unitService;
        }    
    }
}
