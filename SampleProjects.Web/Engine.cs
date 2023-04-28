using Microsoft.Extensions.DependencyInjection;

namespace SampleProjects.Web
{
    public static class Engine
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews();
        }
    }
}
