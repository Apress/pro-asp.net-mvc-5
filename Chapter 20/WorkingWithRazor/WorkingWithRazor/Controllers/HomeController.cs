using System;
using System.Web.Mvc;

namespace WorkingWithRazor.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {
            string[] names = { "Apple", "Orange", "Pear" };
            return View(names);
        }

        public ActionResult List() {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Time() {
            return PartialView(DateTime.Now);
        }
    }
}