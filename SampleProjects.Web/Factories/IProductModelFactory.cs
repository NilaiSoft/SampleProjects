using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProjects.Web.Factories
{
    public interface IProductModelFactory
    {
        Task<IList<ProductModel>> PrepareProductAsync(IList<Product> products);
        Task<ProductModel> PrepareProductModelAsync(ProductModel model, Product product);
        Task<ProductModel> PrepareProductModelAsync(int productId);
    }
}
