﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleProjects.Models;

namespace SampleProjects.Web.BaseController
{
    public interface IBaseController<TEntity, TVModel>
        where TEntity : BaseEntity
    {
        Task<IActionResult> Index();
        Task<IActionResult> Create();

        [HttpPost]
        Task<IActionResult> Create(TVModel entity);
        Task<IActionResult> Edit(int id);

        [HttpPost]
        Task<IActionResult> Edit(TVModel entity);

        Task<IActionResult> Delete(int id);

        Task<IActionResult> Details(int id);
    }
}
