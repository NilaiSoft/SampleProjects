using Microsoft.AspNetCore.Mvc;

namespace SampleProjects.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
