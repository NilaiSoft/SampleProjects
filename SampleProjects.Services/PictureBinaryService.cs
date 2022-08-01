using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Services
{
    public class PictureBinaryService : IPictureBinaryService
    {
        private readonly IRepository<PictureBinary, PictureBinaryModel> _pictureBinaryRepository;

        public PictureBinaryService(IRepository<PictureBinary, PictureBinaryModel> pictureBinaryRepository)
        {
            _pictureBinaryRepository = pictureBinaryRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(PictureBinary pictureBinary, IFormFile formFile)
        {
            if (formFile.ContentType.ToLower().StartsWith("image/"))
            {
                using (BinaryReader br = new BinaryReader(formFile.OpenReadStream()))
                {
                    pictureBinary.BinaryData = br.ReadBytes((int)formFile.OpenReadStream().Length);
                }
            }
            return await _pictureBinaryRepository.AddAndSaveChangesAsync(pictureBinary);
        }

        public async Task<EntityEntry<PictureBinary>> AddAsync(Picture picture, IFormFile formFile)
        {
            var pictureBinary = new PictureBinary();
            if (formFile.ContentType.ToLower().StartsWith("image/"))
            {
                using (BinaryReader br = new BinaryReader(formFile.OpenReadStream()))
                {
                    pictureBinary.BinaryData = br.ReadBytes((int)formFile.OpenReadStream().Length);
                }
                pictureBinary.Picture = picture;
            }
            return await _pictureBinaryRepository.AddAsync(pictureBinary);
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
