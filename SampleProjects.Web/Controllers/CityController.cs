using AutoMapper;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services;
using SampleProjects.Web.BaseController;

namespace SampleProjects.Web.Controllers
{
    public class CityController : BaseController<City, CityModel>
    {
        private readonly IRepository<City, CityModel> _cityRepository;

        public CityController(IRepository<City, CityModel> cityRepository,IMapper mapper)
            : base(cityRepository, mapper)
        {
        }
    }
}
