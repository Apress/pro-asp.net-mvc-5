using System;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers {

    public class ExampleController : Controller {

        public ViewResult Index() {

            ViewBag.Message = "Hello";
            ViewBag.Date = DateTime.Now;

            return View();
        }

        public RedirectToRouteResult Redirect() {
            return RedirectToAction("Index", "Basic");
        }

        public HttpStatusCodeResult StatusCode() {
            return new HttpUnauthorizedResult();
        }



    }
}
