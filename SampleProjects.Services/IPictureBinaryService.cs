using Microsoft.AspNetCore.Http;
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
    public interface IPictureBinaryService
    {
        Task<EntityEntry<PictureBinary>> AddAsync(Picture picture, IFormFile formFile);
        Task<int> AddAndSaveChangesAsync(PictureBinary entity, IFormFile formFile);
        Task<int> EditAsync(PictureBinary pictureBinary);
        Task<int> DeleteAsync(Expression<Func<PictureBinary, bool>> _pridicate);
        Task<IList<PictureBinary>> GetsAsync(Expression<Func<PictureBinary, bool>> _pridicate);
        Task<IList<PictureBinary>> GetsAsync();
        Task<PictureBinary> GetAsync(Expression<Func<PictureBinary, bool>> _pridicate);
        Task<PictureBinary> FindAsync(Expression<Func<PictureBinary, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<PictureBinary, bool>> expression);
        Task<bool> AnyAsync();
    }
}
