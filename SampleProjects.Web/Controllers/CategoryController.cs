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
    public class CategoryController : BaseController<Category, CategoryMoedl>
    {
        private readonly IRepository<Category, CategoryMoedl> _repository;
        public CategoryController(IRepository<Category, CategoryMoedl> repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
        }

        public override Task<IActionResult> Create(CategoryMoedl entity)
        {

            return base.Create(entity);
        }
    }
}
