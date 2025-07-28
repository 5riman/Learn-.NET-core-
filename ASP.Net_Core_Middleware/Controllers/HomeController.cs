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
            ViewData["key1"]= "Hi iam Sriman";
            ViewData["key2"] = "Welcome to ASP.NET Core Middleware Demo";   
            string[] arr = { "ASP.NET Core", "Middleware", "Demo" };
            ViewData["key3"] = arr;
            ViewData["key4"] = new List<string> ()
            { "Sriman","30","Hyderabad" };
             ViewBag.data1 = "Home";
             ViewBag.data2 = "Sriman";
            

            return View();
        }

        
    }
}
