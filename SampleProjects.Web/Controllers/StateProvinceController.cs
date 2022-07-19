using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
    public class StateProvinceController : BaseController<StateProvince, StateProvinceModel>
    {
        public StateProvinceController(IRepository<StateProvince, StateProvinceModel> repository, IMapper mapper)
            : base(repository, mapper)
        {

        }
    }
}
