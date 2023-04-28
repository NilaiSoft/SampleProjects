using AutoMapper;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services;
using SampleProjects.Web.Admin.BaseController;

namespace SampleProjects.Web.Areas.Admin.Controllers
{
    public class CustomerController : AdminBaseController<Customer, CustomerModel>
    {
        private readonly IRepository<Customer, CustomerModel> _customerRepository;
        public CustomerController(IRepository<Customer, CustomerModel> customerRepository, IMapper mapper)
            : base(customerRepository, mapper)
        {
            _customerRepository = customerRepository;
        }
    }
}
