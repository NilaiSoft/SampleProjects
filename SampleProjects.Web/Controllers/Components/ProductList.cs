using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SampleProjects.Services;
using System.Threading.Tasks;

namespace NilaiSofts.Web.Controllers.Components
{
    public class ProductListViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductListViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _productService.GetsAsync();
            return View();
        }
    }
}
