using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5UnhandledExceptionTelemetry.Models;

namespace Mvc5UnhandledExceptionTelemetry.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var r = new Random();
            if (r.Next() % 3 == 0)
            {
                var c = new AboutModels();
                c.saySomething();
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var r = new Random();
            if (r.Next() % 2 == 0)
            {
                var c = new ContactModels();
                c.doSomething();
            }
            return View();
        }
    }
}