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
    public class CityService : ICityService
    {
        private readonly IRepository<City, CityModel> _cityRepository;

        public CityService(IRepository<City, CityModel> cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(City entity)
        {
            return await _cityRepository.AddAndSaveChangesAsync(entity);
        }

        public async Task<EntityEntry<City>> AddAsync(City item)
        {
            return await _cityRepository.AddAsync(item);
        }

        public async Task<bool> AnyAsync(Expression<Func<City, bool>> expression)
        {
            return await _cityRepository.AnyAsync(expression);
        }

        public async Task<bool> AnyAsync()
        {
            return await _cityRepository.AnyAsync();
        }

        public async Task<int> DeleteAsync(Expression<Func<City, bool>> _pridicate)
        {
            return await _cityRepository.DeleteAsync(_pridicate);
        }

        public async Task<City> FindAsync(Expression<Func<City, bool>> predicate)
        {
            return await _cityRepository.FindAsync(predicate);
        }

        public async Task<City> GetAsync(Expression<Func<City, bool>> _pridicate)
        {
            return await _cityRepository.GetAsync(_pridicate);
        }

        public async Task<IList<City>> GetsAsync(Expression<Func<City, bool>> _pridicate)
        {
            return await _cityRepository.GetsAsync(_pridicate);
        }

        public async Task<IList<City>> GetsAsync()
        {
            return await _cityRepository.GetsAsync();
        }

        public async Task<int> EditAsync(City city)
        {
            return await _cityRepository.EditAsync(city);
        }
    }
}
