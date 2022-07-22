using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services;
using SampleProjects.Web.BaseController;
using System.Threading.Tasks;

namespace SampleProjects.Web.Controllers
{
    public class ProductController : BaseController<Product, ProductModel>
    {
        private readonly IProductService _productService;
        private readonly IUnitService _unitService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductService productService,
            IUnitService unitService, IMapper mapper
            , IRepository<Product, ProductModel> repository, ILogger<ProductController> logger) : base(repository, mapper)
        {
            _productService = productService;
            _unitService = unitService;
            _logger = logger;
            _logger.LogDebug(1, $"NLog injected into {nameof(ProductController)}");
        }

        public override async Task<IActionResult> Index()
        {
            _logger.LogInformation(nameof(Index));
            var products = await _productService.GetsAsync();
            return View(products);
        }

        public override async Task<IActionResult> Create()
        {
            var units = await _unitService.GetsAsync();
            ViewBag.UnitList = new SelectList(units, "Id", "Name");
            return await base.Create();
        }

        [HttpPost]
        public override async Task<IActionResult> Create(ProductModel entity)
        {
            await _productService.AddAndSaveChangesAsync(entity);
            return RedirectToAction(nameof(Index));
        }

        public override async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetAsync(x => x.Id == id);
            var units = await _unitService.GetsAsync();
            ViewBag.UnitList = new SelectList(units, "Id", "Name");
            return await base.Edit(id);
        }

        public override async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetAsync(x => x.Id == id,
            x => new Product
            {
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
                StockQuantity = x.StockQuantity,
                UnitId = x.UnitId,
                Unit = x.Unit
            });
            return View(product);
        }
    }
}
