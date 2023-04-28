using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SampleProjects.Web.Infrastructure
{
    public static class DependencyRegistrar
    {
        public static void WebRegister(this IServiceCollection services)
        {
            var appServices = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.FullName.EndsWith("ModelFactory") 
                && t.FullName.StartsWith("SampleProjects.Web.Factories")
                && (t.IsClass || t.IsInterface))
                .Select(x => x);

            appServices = appServices
                .Where(x => x.FullName.StartsWith("SampleProjects.Web.Factories"));

            foreach (var IService in appServices
                .Where(x => x.FullName.StartsWith("SampleProjects.Web.Factories")))
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
