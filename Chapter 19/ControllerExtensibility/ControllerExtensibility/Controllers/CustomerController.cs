using System.Web.Mvc;
using ControllerExtensibility.Models;

namespace ControllerExtensibility.Controllers {
    public class CustomerController : Controller {

        public ViewResult Index() {
            return View("Result", new Result {
                ControllerName = "Customer",
                ActionName = "Index"
            });
        }

        [ActionName("Enumerate")]
        public ViewResult List() {
            return View("Result", new Result {
                ControllerName = "Customer",
                ActionName = "List"
            });
        }

        [NonAction]
        public ActionResult MyAction() {
            return View();
        }
    }
}
