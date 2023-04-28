using AutoMapper;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services;
using SampleProjects.Web.Admin.BaseController;

namespace SampleProjects.Web.Admin.Controllers
{
    public class CityController : AdminBaseController<City, CityModel>
    {
        private readonly IRepository<City, CityModel> _cityRepository;

        public CityController(IRepository<City, CityModel> cityRepository,IMapper mapper)
            : base(cityRepository, mapper)
        {
        }
    }
}
