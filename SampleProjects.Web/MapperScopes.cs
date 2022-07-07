using Microsoft.Extensions.DependencyInjection;
using SampleProjects.Models;
using SampleProjects.Services;

namespace SampleProjects.Web
{
    public static class MapperScopes
    {
        public static void Mapper(this IServiceCollection services)
        {
            services.AddScoped<IRepository<City>, Repository<City>>();
            services.AddScoped<IRepository<StateProvince>, Repository<StateProvince>>();
        }
    }
}
