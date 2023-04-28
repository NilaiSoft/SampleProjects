using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Services.UnitOfWork
{
    public interface IUnitOfWork
    {
        //IUserRepository Users { get; }

        Task<int> CompleteAsync();
    }
}
