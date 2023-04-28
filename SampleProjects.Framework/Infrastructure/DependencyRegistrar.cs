using Microsoft.Extensions.DependencyInjection;
using SampleProjects.Services;
using System;
using System.Linq;

namespace SampleProjects.Framework.Infrastructure
{
    public static class DependencyRegistrar
    {
        public static void Register(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

            var appServices = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => (t.FullName.EndsWith("Service") || t.FullName.EndsWith("ModelFactory"))
                && (t.IsClass || t.IsInterface))
                .Select(x => x);

            appServices = appServices
                .Where(x => x.FullName.StartsWith("SampleProjects.Services"));

            foreach (var IService in appServices
                .Where(x => x.FullName.StartsWith("SampleProjects.Services")))
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
