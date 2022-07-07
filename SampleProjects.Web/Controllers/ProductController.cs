using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SampleProjects.Models;
using SampleProjects.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProjects.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IUnitService _unitService;

        public ProductController(IProductService productService,
            IUnitService unitService)
        {
            _productService = productService;
            _unitService = unitService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetsAsync();
            return View(products);
        }

        public async Task<IActionResult> Create()
        {
            var units = await _unitService.GetsAsync();
            ViewBag.UnitList = new SelectList(units, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            await _productService.AddAndSaveChangesAsync(product);
            return RedirectToAction("Index");
        }
    }
}
