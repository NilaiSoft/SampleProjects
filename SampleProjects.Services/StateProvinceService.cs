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
    public class StateProvinceService : IStateProvinceService
    {
        private readonly IRepository<StateProvince, StateProvinceModel> _StateProvinceRepository;

        public StateProvinceService(IRepository<StateProvince, StateProvinceModel> StateProvinceRepository)
        {
            _StateProvinceRepository = StateProvinceRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(StateProvince entity)
        {
            return await _StateProvinceRepository.AddAndSaveChangesAsync(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _StateProvinceRepository.SaveChangesAsync();
        }

        public async Task<EntityEntry<StateProvince>> AddAsync(StateProvince item)
        {
            return await _StateProvinceRepository.AddAsync(item);
        }

        public async Task<bool> AnyAsync(Expression<Func<StateProvince, bool>> expression)
        {
            return await _StateProvinceRepository.AnyAsync(expression);
        }

        public async Task<bool> AnyAsync()
        {
            return await _StateProvinceRepository.AnyAsync();
        }

        public async Task<int> DeleteAsync(Expression<Func<StateProvince, bool>> _pridicate)
        {
            return await _StateProvinceRepository.DeleteAsync(_pridicate);
        }

        public async Task<StateProvince> FindAsync(Expression<Func<StateProvince, bool>> predicate)
        {
            return await _StateProvinceRepository.FindAsync(predicate);
        }

        public async Task<StateProvince> GetAsync(Expression<Func<StateProvince, bool>> _pridicate)
        {
            return await _StateProvinceRepository.GetAsync(_pridicate);
        }

        public async Task<IList<StateProvince>> GetsAsync(Expression<Func<StateProvince, bool>> _pridicate)
        {
            return await _StateProvinceRepository.GetsAsync(_pridicate);
        }

        public async Task<IList<StateProvince>> GetsAsync()
        {
            return await _StateProvinceRepository.GetsAsync(x => new StateProvince
            {
                Name = x.Name,
                Id = x.Id
            });
        }

        public async Task<IList<StateProvince>> GetsAsync(Expression<Func<StateProvince, StateProvince>> expression)
        {
            return await _StateProvinceRepository.GetsAsync();
        }

        public async Task<StateProvince> GetAsync(Expression<Func<StateProvince, bool>> _pridicate, Expression<Func<StateProvince, StateProvince>> selectItem)
        {
            return await _StateProvinceRepository.GetAsync(_pridicate, selectItem);
        }
    }
}
