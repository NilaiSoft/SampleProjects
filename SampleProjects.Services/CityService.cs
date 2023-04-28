using Microsoft.EntityFrameworkCore.ChangeTracking;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;
using SampleProjects.Services.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects.Services
{
    public class CityService : Repository<City, CityModel>, ICityService
    {
        public CityService(ApplicationDbContext context
            , IUnitOfWork uow) : base(context, uow)
        {

        }
    }
}
