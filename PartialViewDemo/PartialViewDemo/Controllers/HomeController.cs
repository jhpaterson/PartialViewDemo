using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Partial view example";

            return View();
        }

        public ActionResult Ajax()
        {
            ViewBag.Message = "Partial view with Ajax example";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Content()
        {
            ViewBag.Content = "Here is some content";

            return PartialView();
        }
    }
}
