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

            foreach (var IService in appServices)
            {
                var Service = appServices.FirstOrDefault
                    (x => x.Name == IService.Name.Substring
                    (1, IService.Name.Length - 1));
                if (Service != null)
                    services.AddScoped(IService, Service);
            }

        }
    }
}
