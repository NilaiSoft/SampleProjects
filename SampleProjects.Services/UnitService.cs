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
    public class UnitService : IUnitService
    {
        private readonly IRepository<Unit> _unitRepository;

        public UnitService(IRepository<Unit> unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public async Task<int> AddAndSaveChangesAsync(Unit entity)
        {
            return await _unitRepository.AddAndSaveChangesAsync(entity);
        }

        public async Task<EntityEntry<Unit>> AddAsync(Unit item)
        {
            return await _unitRepository.AddAsync(item);
        }

        public async Task<bool> AnyAsync(Expression<Func<Unit, bool>> expression)
        {
            return await _unitRepository.AnyAsync(expression);
        }

        public async Task<bool> AnyAsync()
        {
            return await _unitRepository.AnyAsync();
        }

        public async Task<int> DeleteAsync(Expression<Func<Unit, bool>> _pridicate)
        {
            return await _unitRepository.DeleteAsync(_pridicate);
        }

        public async Task<Unit> FindAsync(Expression<Func<Unit, bool>> predicate)
        {
            return await _unitRepository.FindAsync(predicate);
        }

        public async Task<Unit> GetAsync(Expression<Func<Unit, bool>> _pridicate)
        {
            return await _unitRepository.GetAsync(_pridicate);
        }

        public async Task<IList<Unit>> GetsAsync(Expression<Func<Unit, bool>> _pridicate)
        {
            return await _unitRepository.GetsAsync(_pridicate);
        }

        public async Task<IList<Unit>> GetsAsync()
        {
            return await _unitRepository.GetsAsync();
        }

        public async Task<int> EditAsync
            (Expression<Func<Unit, bool>> predicate, Expression<Func<Unit, Unit>> expression)
        {
            return await _unitRepository.EditAsync(predicate, expression);
        }

        public async Task<int> EditAsync(Unit unit)
        {
            return await _unitRepository.EditAsync(unit);
        }
    }
}
