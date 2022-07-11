using Microsoft.AspNetCore.Mvc;
using SampleProjects.Models;
using SampleProjects.Services;
using SampleProjects.Web.BaseController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProjects.Web.Controllers
{
    public class StateProvinceController : BaseController<StateProvince>
    {
        private readonly IRepository<StateProvince> _repository;
        public StateProvinceController(IRepository<StateProvince> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
