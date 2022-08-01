using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SampleProjects.Services;
using SampleProjects.Web.Factories;
using System.Threading.Tasks;

namespace NilaiSofts.Web.Controllers.Components
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly ICategoryModelFactory _categoryModelFactory;

        public CategoryListViewComponent(ICategoryService categoryService, ICategoryModelFactory categoryModelFactory)
        {
            _categoryService = categoryService;
            _categoryModelFactory = categoryModelFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var category = await _categoryService.GetsAsync();
            var model = await _categoryModelFactory.PrepareCategoryAsync(category);
            return View(model);
        }
    }
}
