using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(SampleProjects.Web.Areas.Identity.IdentityHostingStartup))]
namespace SampleProjects.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}