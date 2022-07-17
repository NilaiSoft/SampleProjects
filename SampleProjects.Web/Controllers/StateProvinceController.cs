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
        private readonly IRepository<StateProvince, StateProvinceModel> _repository;
        private static readonly IMapper _mapper;
        public StateProvinceController(IRepository<StateProvince, StateProvinceModel> repository)
            : base(repository,_mapper)
        {
            _repository = repository;
        }
    }
}
