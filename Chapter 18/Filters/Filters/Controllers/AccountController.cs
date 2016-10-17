using System.Web.Mvc;
using System.Web.Security;

namespace Filters.Controllers {
    public class AccountController : Controller {

        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string returnUrl) {
            bool result = FormsAuthentication.Authenticate(username, password);
            if (result) {
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
            } else {
                ModelState.AddModelError("", "Incorrect username or password");
                return View();
            }
        }
    }
}
