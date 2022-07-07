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

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetAsync(x => x.Id == id);
            var units = await _unitService.GetsAsync();
            ViewBag.UnitList = new SelectList(units, "Id", "Name");
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            await _productService.EditAsync(
                 x => x.Id == product.Id,
                 x => new Product
                 {
                     Name = product.Name,
                     StockQuantity = product.StockQuantity,
                     Description = product.Description,
                     UnitId = product.UnitId,
                 });
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int id)
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

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _productService.DeleteAsync(x => x.Id == id);
            return RedirectToAction("Index");
        }
    }
}
