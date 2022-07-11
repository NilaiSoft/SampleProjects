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

            var appServices = from t in AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes())
                              where (t.FullName.EndsWith("Service") && 
                              (t.IsClass || t.IsInterface))
                              select t;

            foreach (var iService in appServices)
            {
                var service = appServices.FirstOrDefault
                    (x => x.Name == iService.Name.Substring
                    (1, iService.Name.Length - 1));
                if (service != null)
                    services.AddScoped(iService, service);
            }

        }
    }
}
