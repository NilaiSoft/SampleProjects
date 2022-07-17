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
    public class PictureBinaryService : IPictureBinaryService
    {
        private readonly IRepository<PictureBinary> _pictureBinaryRepository;

        public PictureBinaryService(IRepository<PictureBinary> pictureBinaryRepository)
        {
            _pictureBinaryRepository = pictureBinaryRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(PictureBinary entity)
        {
            return await _pictureBinaryRepository.AddAndSaveChangesAsync(entity);
        }

        public async Task<EntityEntry<PictureBinary>> AddAsync(PictureBinary item)
        {
            return await _pictureBinaryRepository.AddAsync(item);
        }

        public async Task<bool> AnyAsync(Expression<Func<PictureBinary, bool>> expression)
        {
            return await _pictureBinaryRepository.AnyAsync(expression);
        }

        public async Task<bool> AnyAsync()
        {
            return await _pictureBinaryRepository.AnyAsync();
        }

        public async Task<int> DeleteAsync(Expression<Func<PictureBinary, bool>> _pridicate)
        {
            return await _pictureBinaryRepository.DeleteAsync(_pridicate);
        }

        public async Task<PictureBinary> FindAsync(Expression<Func<PictureBinary, bool>> predicate)
        {
            return await _pictureBinaryRepository.FindAsync(predicate);
        }

        public async Task<PictureBinary> GetAsync(Expression<Func<PictureBinary, bool>> _pridicate)
        {
            return await _pictureBinaryRepository.GetAsync(_pridicate);
        }

        public async Task<IList<PictureBinary>> GetsAsync(Expression<Func<PictureBinary, bool>> _pridicate)
        {
            return await _pictureBinaryRepository.GetsAsync(_pridicate);
        }

        public async Task<IList<PictureBinary>> GetsAsync()
        {
            return await _pictureBinaryRepository.GetsAsync();
        }

        public async Task<int> EditAsync(PictureBinary pictureBinary)
        {
            return await _pictureBinaryRepository.EditAsync(pictureBinary);
        }
    }
}
