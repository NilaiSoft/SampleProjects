using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProjects.Web.Factories
{
    public interface ICategoryModelFactory
    {
        Task<IList<CategoryModel>> PrepareCategoryAsync(IList<Category> categorys);
        Task<CategoryModel> PrepareCategoryModelAsync(Category category);
        Task<CategoryModel> PrepareCategoryModelAsync(int categoryId);
    }
}
