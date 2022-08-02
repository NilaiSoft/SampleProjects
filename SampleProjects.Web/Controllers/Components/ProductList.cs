using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SampleProjects.Services;
using SampleProjects.Web.Factories;
using System.Threading.Tasks;

namespace NilaiSofts.Web.Controllers.Components
{
    public class ProductListViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IProductModelFactory _productModelFactory;

        public ProductListViewComponent(IProductService productService, IProductModelFactory productModelFactory)
        {
            _productService = productService;
            _productModelFactory = productModelFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _productService.GetsAsync();
            var model = await _productModelFactory.PrepareProductAsync(products);
            return View(model);
        }
    }
}
