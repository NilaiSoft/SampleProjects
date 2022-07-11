using Microsoft.AspNetCore.Mvc;
using SampleProjects.Models;
using SampleProjects.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProjects.Web.BaseController
{
    public class BaseController<TEntity> : Controller,
        IBaseController<TEntity> where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> _repository;

        public BaseController(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task<IActionResult> Index()
        {
            var model = await _repository.GetsAsync();
            return View(model);
        }

        public virtual async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create(TEntity entity)
        {
            var result = await _repository.AddAndSaveChangesAsync(entity);
            return RedirectToAction("Index");
        }

        public virtual async Task<IActionResult> Edit(int id)
        {
            var model = await _repository.GetAsync(x => x.Id == id);
            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Edit(TEntity entity)
        {
            var result = await _repository.EditAsync(entity);
            return RedirectToAction("Index");
        }

        public virtual async Task<IActionResult> Delete(int id)
        {
            var result = await _repository.DeleteAsync(x => x.Id == id);
            return RedirectToAction("Index");
        }
    }
}
