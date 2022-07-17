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
    public class CategoryController : BaseController<Category>
    {
        private readonly IRepository<Category> _repository;
        public CategoryController(IRepository<Category> repository)
            : base(repository)
        {
            _repository = repository;
        }

        public override Task<IActionResult> Create(Category entity)
        {

            return base.Create(entity);
        }
    }
}
