using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewDemo.Controllers
{
    public class HomeController : Controller
    {
        // Try the following:
        // URL / or /Home/Index, Index view passes new{id=3} as route value to Content child action
        // URL /Home/IndexParam/4, Content child action binds parameter to route value in URL of parent action
        // URL / or /Home/Ajax, Ajax view passes new{id=5} as route value to Content action from client code (uncomment ChildActionOnly attribute)
        // URL / or /Home/IndexPartial, IndexPartial view renders Content view directly rather than invoking action,
        // and passes it a model object (integer value 6)
        // note availability of ViewBag values in each case

        public ActionResult Index()
        {
            ViewBag.Message = "Partial view example";

            return View();
        }

        public ActionResult IndexParam()
        {
            ViewBag.Message = "Partial view example";

            return View();
        }

        public ActionResult IndexPartial()
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
        public ActionResult Content(int id)
        {
            ViewBag.Content = "Here is the partial view";

            return PartialView(id);
        }

    }
}
