using Microsoft.EntityFrameworkCore.ChangeTracking;
using SampleProjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Services
{
    public interface IProductPictureService
    {
        Task<EntityEntry<ProductPicture>> AddAsync(ProductPicture item);
        Task<int> AddAndSaveChangesAsync(ProductPicture entity);
        Task<int> EditAsync(ProductPicture productPicture);
        Task<int> DeleteAsync(Expression<Func<ProductPicture, bool>> _pridicate);
        Task<IList<ProductPicture>> GetsAsync(Expression<Func<ProductPicture, bool>> _pridicate);
        Task<IList<ProductPicture>> GetsAsync();
        Task<ProductPicture> GetAsync(Expression<Func<ProductPicture, bool>> _pridicate);
        Task<ProductPicture> FindAsync(Expression<Func<ProductPicture, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<ProductPicture, bool>> expression);
        Task<bool> AnyAsync();
    }
}
