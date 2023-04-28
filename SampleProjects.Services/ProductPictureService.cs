using Microsoft.EntityFrameworkCore.ChangeTracking;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Services
{
    public class ProductPictureService : Repository<ProductPicture, ProductPictureModel>, IProductPictureService
    {
        public ProductPictureService(ApplicationDbContext context
            , IUnitOfWork uow) : base(context, uow)
        {

        }
    }
}
