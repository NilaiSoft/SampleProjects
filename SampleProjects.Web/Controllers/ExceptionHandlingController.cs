using Microsoft.AspNetCore.Mvc;

namespace SampleProjects.Web.Controllers
{
    public class ExceptionHandlingController : Controller
    {
        public IActionResult Index(string exception, int statusCode)
        {
            var model = new ErrorDetails
            {
                Message = exception,
                StatusCode = statusCode
            };

            return View(model);
        }
    }
}
