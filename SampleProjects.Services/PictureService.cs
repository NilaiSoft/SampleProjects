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
    public class PictureService : IPictureService
    {
        private readonly IRepository<Picture, PictureModel> _pictureRepository;

        public PictureService(IRepository<Picture, PictureModel> pictureRepository)
        {
            _pictureRepository = pictureRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(Picture entity)
        {
            return await _pictureRepository.AddAndSaveChangesAsync(entity);
        }

        public async Task<EntityEntry<Picture>> AddAsync(Picture item)
        {
            return await _pictureRepository.AddAsync(item);
        }

        public async Task<bool> AnyAsync(Expression<Func<Picture, bool>> expression)
        {
            return await _pictureRepository.AnyAsync(expression);
        }

        public async Task<bool> AnyAsync()
        {
            return await _pictureRepository.AnyAsync();
        }

        public async Task<int> DeleteAsync(Expression<Func<Picture, bool>> _pridicate)
        {
            return await _pictureRepository.DeleteAsync(_pridicate);
        }

        public async Task<Picture> FindAsync(Expression<Func<Picture, bool>> predicate)
        {
            return await _pictureRepository.FindAsync(predicate);
        }

        public async Task<Picture> GetAsync(Expression<Func<Picture, bool>> _pridicate)
        {
            return await _pictureRepository.GetAsync(_pridicate);
        }

        public async Task<IList<Picture>> GetsAsync(Expression<Func<Picture, bool>> _pridicate)
        {
            return await _pictureRepository.GetsAsync(_pridicate);
        }

        public async Task<IList<Picture>> GetsAsync()
        {
            return await _pictureRepository.GetsAsync();
        }

        public async Task<int> EditAsync(Picture picture)
        {
            return await _pictureRepository.EditAsync(picture);
        }
    }
}
