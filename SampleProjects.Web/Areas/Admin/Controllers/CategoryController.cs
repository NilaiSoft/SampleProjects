using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services;
using SampleProjects.Web.Admin.BaseController;
using System.Threading.Tasks;

namespace SampleProjects.Web.Admin.Controllers
{
    public class CategoryController : AdminBaseController<Category, CategoryMoedl>
    {
        private readonly IRepository<Category, CategoryMoedl> _repository;
        public CategoryController(IRepository<Category, CategoryMoedl> repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
        }

        [HttpPost]
        public override Task<IActionResult> Create(CategoryMoedl entity)
        {
            return base.Create(entity);
        }
    }
}
