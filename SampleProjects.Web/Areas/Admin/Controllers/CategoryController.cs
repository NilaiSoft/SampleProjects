using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services;
using SampleProjects.Web.Admin.BaseController;
using System.Threading.Tasks;

namespace SampleProjects.Web.Admin.Controllers
{
    public class CategoryController : AdminBaseController<Category, CategoryModel>
    {
        private readonly IRepository<Category, CategoryModel> _repository;
        public CategoryController(IRepository<Category, CategoryModel> repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
        }

        [HttpPost]
        public override Task<IActionResult> Create(CategoryModel entity)
        {
            return base.Create(entity);
        }
    }
}
