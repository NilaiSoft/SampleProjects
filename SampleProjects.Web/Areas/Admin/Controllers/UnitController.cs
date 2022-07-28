using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services;
using SampleProjects.Web.Admin.BaseController;
using SampleProjects.Web.BaseController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProjects.Web.Admin.Controllers
{
    public class UnitController : AdminBaseController<Unit, UnitModel>
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
