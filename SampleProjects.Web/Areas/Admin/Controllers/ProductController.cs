﻿namespace SampleProjects.Web.Admin.Controllers
{
    public class ProductController : AdminBaseController<Product, ProductModel>
    {
        private readonly IProductService _productService;
        private readonly IPictureService _pictureService;
        private readonly IProductPictureService _productPictureService;
        private readonly IProductModelFactory _productModelFactory;
        private readonly IPictureBinaryService _pictureBinaryService;
        private readonly IUnitService _unitService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService,
            IUnitService unitService, IMapper mapper
            , IRepository<Product, ProductModel> repository, ILogger<ProductController> logger, IPictureService pictureService, IPictureBinaryService pictureBinaryService, IProductPictureService productPictureService, IProductModelFactory productModelFactory, IUnitOfWork unitOfWork) : base(repository, mapper)
        {
            _productService = productService;
            _unitService = unitService;
            _logger = logger;
            _logger.LogDebug(1, $"NLog injected into {nameof(ProductController)}");
            _mapper = mapper;
            _pictureService = pictureService;
            _pictureBinaryService = pictureBinaryService;
            _productPictureService = productPictureService;
            _productModelFactory = productModelFactory;
            _unitOfWork = unitOfWork;
        }

        public override async Task<IActionResult> Index()
        {
            _logger.LogInformation(nameof(Index));
            var products = await _productService.GetsAsync();
            var model = await _productModelFactory.PrepareProductAsync(products);
            return View(model);
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
            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {
                    await _unitOfWork.BeginTransactionAsync();
                    var pEntity = _mapper.Map<Product>(pModel);
                    var product = await _productService.AddAsync(pEntity);

                    var picEntity = new Picture
                    {
                        AltAttribute = pModel.Name,
                        SeoFilename = pModel.Name,
                        TitleAttribute = pModel.Name
                    };
                    var picture = await _pictureService.AddAsync(picEntity);

                    //await _pictureBinaryService.AddAsync(picture.Entity, pModel.ImageFile);

                    var picProductEntity = new ProductPicture
                    {
                        Product = pEntity,
                        Picture = picEntity
                    };

                    var pictureProduct = await _productPictureService
                        .AddAndSaveChangesAsync(picProductEntity);

                    await _unitOfWork.CommitAsync();

                    return RedirectToAction(nameof(Index));
                }

                var units = await _unitService.GetsAsync();
                ViewBag.UnitList = new SelectList(units, "Id", "Name");
                return View();
            }
            catch
            {
                await _unitOfWork.RoolbackAsync();
                var units = await _unitService.GetsAsync();
                ViewBag.UnitList = new SelectList(units, "Id", "Name");
                return View();
            }
        }

        public override async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetAsync(x => x.Id == id);
            var units = await _unitService.GetsAsync();
            ViewBag.UnitList = new SelectList(units, "Id", "Name");
            return await base.Edit(id);
        }
    }
}
