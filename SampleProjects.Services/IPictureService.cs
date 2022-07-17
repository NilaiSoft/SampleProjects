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
    public interface IPictureService
    {
        Task<EntityEntry<Picture>> AddAsync(Picture item);
        Task<int> AddAndSaveChangesAsync(Picture entity);
        Task<int> EditAsync(Picture picture);
        Task<int> DeleteAsync(Expression<Func<Picture, bool>> _pridicate);
        Task<IList<Picture>> GetsAsync(Expression<Func<Picture, bool>> _pridicate);
        Task<IList<Picture>> GetsAsync();
        Task<Picture> GetAsync(Expression<Func<Picture, bool>> _pridicate);
        Task<Picture> FindAsync(Expression<Func<Picture, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<Picture, bool>> expression);
        Task<bool> AnyAsync();
    }
}
