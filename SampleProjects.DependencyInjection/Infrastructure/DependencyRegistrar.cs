using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SampleProjects.Framework.Infrastructure
{
    public static class DependencyRegistrar
    {
        public static void Register(this IServiceCollection services)
        {
            var appServices = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.FullName.EndsWith("Service")
                && (t.IsClass || t.IsInterface))
                .Select(x => x);

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
