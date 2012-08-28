using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";
            ViewData["Title"] = "Home Page";

            return View();
        }

        public ActionResult About()
        {
            ViewData["Title"] = "About Page";
            return View();
        }
    }
}
