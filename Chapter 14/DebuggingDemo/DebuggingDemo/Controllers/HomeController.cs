using System.Web.Mvc;

namespace DebuggingDemo.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {
            int firstVal = 10;
            int secondVal = 0;
            int result = firstVal / 2;

            // This statement has been commented out
            //ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View(result);
        }
    }
}
