using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SampleProjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Services.UnitOfWork
{
    public class UnitOfWork : DbContext, IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _dataContext;

        public UnitOfWork(ApplicationDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<int> CompleteAsync()
        {
            return await _dataContext.CommitAsync();
        }
    }
}
