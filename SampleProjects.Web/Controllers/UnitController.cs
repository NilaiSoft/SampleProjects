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
    public class UnitController : Controller
    {
        private readonly IProductService _productService;
        private readonly IUnitService _unitService;

        public UnitController(IProductService productService,
            IUnitService unitService)
        {
            _productService = productService;
            _unitService = unitService;
        }

        public async Task<IActionResult> Index()
        {
            var units = await _unitService.GetsAsync();
            return View(units);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Unit unit)
        {
            await _unitService.AddAndSaveChangesAsync(unit);
            return RedirectToAction("Index");
        }
    }
}
