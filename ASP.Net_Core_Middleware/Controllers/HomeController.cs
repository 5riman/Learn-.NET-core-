using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Middleware.Controllers
{
[Route("[controller]")]
    public class HomeController : Controller
    {
      [Route("")]
      [Route("[action]")]
      [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
