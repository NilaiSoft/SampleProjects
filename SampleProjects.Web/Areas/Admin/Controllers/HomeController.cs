using Microsoft.AspNetCore.Mvc;

namespace SampleProjects.Web.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
