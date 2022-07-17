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
    public class CityController : BaseController<City, CityModel>
    {
        private readonly IRepository<City, CityModel> _cityRepository;
        private static readonly IMapper _mapper;

        public CityController(IRepository<City, CityModel> cityRepository)
            : base(cityRepository, _mapper)
        {
        }
    }
}
