using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample1.Controllers
{
    public class TestController:Controller
    {
        public ViewResult register()
        {
            return View();

        }
      public ViewResult Login()
        {
            return View();
        }

    }
}