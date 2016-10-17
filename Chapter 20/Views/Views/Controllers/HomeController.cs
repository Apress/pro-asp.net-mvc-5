using System;
using System.Web.Mvc;

namespace Views.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {
            ViewBag.Message = "Hello, World";
            ViewBag.Time = DateTime.Now.ToShortTimeString();
            return View("DebugData");
        }

        public ActionResult List() {
            return View();
        }
    }
}
