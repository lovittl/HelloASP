using HelloASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Photos()
        {
            var model = new PhotoModel
            {
                AltText = "Hello World!",
                URL = "http://www.example.com/itDoesntexist"
            };
            return View(model);
        }
    }
}