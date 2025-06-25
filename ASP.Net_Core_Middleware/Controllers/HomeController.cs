using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Middleware.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
