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
    public class CategoryController : BaseController<Category, CategoryModel>
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
