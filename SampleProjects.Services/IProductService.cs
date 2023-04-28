using Microsoft.EntityFrameworkCore.ChangeTracking;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Services
{
    public interface IProductService: IRepository<Product, ProductModel>
    {
        
    }
}
