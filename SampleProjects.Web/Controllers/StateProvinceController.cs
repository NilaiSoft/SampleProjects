using AutoMapper;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services;
using SampleProjects.Web.BaseController;

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
