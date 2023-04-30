using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleProjects.Models;
using SampleProjects.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProjects.Web.Admin.BaseController
{
	[Area("admin")]
	public class AdminBaseController<TEntity, TVModel> : Controller,
		IAdminBaseController<TEntity, TVModel> where TEntity : BaseEntity
	{
		private readonly IRepository<TEntity, TVModel> _repository;
		private readonly IMapper _mapper;

		public AdminBaseController(IRepository<TEntity, TVModel> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public virtual async Task<IActionResult> Index()
		{
			var entity = await _repository.GetsAsync();
			var model = _mapper.Map<IList<TVModel>>(entity);
			return View(model);
		}

		public virtual async Task<IActionResult> Create()
		{
			return View();
		}

		[HttpPost]
		public virtual async Task<IActionResult> Create(TVModel entity)
		{
			if (ModelState.IsValid)
			{
				var model = _mapper.Map<TEntity>(entity);

				var result = await _repository.AddAndSaveChangesAsync(model);
				return RedirectToAction("Index");
			}

			return View();
		}

		public virtual async Task<IActionResult> Edit(int id)
		{
			var model = await _repository.GetAsync(x => x.Id == id);
			var model2 = _mapper.Map<TVModel>(model);

			return View(model2);
		}

		[HttpPost]
		public virtual async Task<IActionResult> Edit(TVModel entity)
		{
			if (ModelState.IsValid)
			{
				var model = _mapper.Map<TEntity>(entity);
				var result = await _repository.EditAsync(model);

				return RedirectToAction("Index");
			}

			return View();
		}

		public virtual async Task<IActionResult> Delete(int id)
		{
			var result = await _repository.DeleteAsync(x => x.Id == id);
			return RedirectToAction("Index");
		}

		public virtual async Task<IActionResult> Details(int id)
		{
			var model = await _repository.GetAsync(x => x.Id == id);
			return View(_mapper.Map<TVModel>(model));
		}
	}
}
