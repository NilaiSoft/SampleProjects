using Microsoft.AspNetCore.Mvc;

namespace SampleProjects.Web.Controllers
{
    public class ExceptionHandlingController : Controller
    {
        public PartialViewResult Index(string exception, int statusCode)
        {
            var model = new ErrorDetails
            {
                Message = exception,
                StatusCode = statusCode
            };

            return PartialView(model);
        }
    }
}
