using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Services.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        protected ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task BeginTransactionAsync()
        {
            await _context.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            await _context.CommitAsync();
        }

        public async Task RoolbackAsync()
        {
            await _context.RoolbackAsync();
        }
    }
}
