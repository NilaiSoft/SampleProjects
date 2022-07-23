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
        private readonly IPictureService _pictureService;
        private readonly IProductPictureService _productPictureService;
        private readonly IPictureBinaryService _pictureBinaryService;
        private readonly IUnitService _unitService;
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService,
            IUnitService unitService, IMapper mapper
            , IRepository<Product, ProductModel> repository, ILogger<ProductController> logger, IPictureService pictureService, IPictureBinaryService pictureBinaryService, IProductPictureService productPictureService) : base(repository, mapper)
        {
            _productService = productService;
            _unitService = unitService;
            _logger = logger;
            _logger.LogDebug(1, $"NLog injected into {nameof(ProductController)}");
            _mapper = mapper;
            _pictureService = pictureService;
            _pictureBinaryService = pictureBinaryService;
            _productPictureService = productPictureService;
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
        public override async Task<IActionResult> Create(ProductModel pModel)
        {
            if (ModelState.IsValid)
            {
                var pEntity = _mapper.Map<Product>(pModel);
                var product = await _productService.AddAsync(pEntity);

                var picEntity = new Picture
                {
                    AltAttribute = pModel.Name,
                    SeoFilename = pModel.Name,
                    TitleAttribute = pModel.Name
                };
                var picture = await _pictureService.AddAsync(picEntity);

                var picBinaryEntity = new PictureBinary
                {
                    Picture = picEntity
                };
                var pictureBinary = await _pictureBinaryService
                    .AddAsync(picBinaryEntity);

                var picProductEntity = new ProductPicture
                {
                    Product = pEntity,
                    Picture = picEntity
                };
                var pictureProduct = await _productPictureService
                    .AddAndSaveChangesAsync(picProductEntity);

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public override async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetAsync(x => x.Id == id);
            var units = await _unitService.GetsAsync();
            ViewBag.UnitList = new SelectList(units, "Id", "Name");
            return await base.Edit(id);
        }

        [HttpPost]
        public override async Task<IActionResult> Edit(ProductModel pModel)
        {
            var product = _mapper.Map<Product>(pModel);
            await _productService.EditAsync(product);
            return RedirectToAction(nameof(Index));
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
