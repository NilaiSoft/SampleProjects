using Microsoft.Extensions.DependencyInjection;
using SampleProjects.Models;
using SampleProjects.Services;
using System;
using System.Linq;

namespace SampleProjects.Web
{
    public static class MapperScopes
    {
        public static void Mapper(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
