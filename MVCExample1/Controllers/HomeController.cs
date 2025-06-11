using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample1.Controllers
{
    public class HomeController:Controller
    {
        public string Hello()
        {
            return "My name is sriman";

        }

        public string Index()
        {
            return "Hello iam Index";
        }
    }
}