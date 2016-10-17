using System.Web.Mvc;

namespace TestingDemo {

    public class AdminController : Controller {
        private IUserRepository repository;

        public AdminController(IUserRepository repo) {
            repository = repo;
        }

        public ActionResult ChangeLoginName(string oldName, string newName) {
            User user = repository.FetchByLoginName(oldName);
            user.LoginName = newName;
            repository.SubmitChanges();
            // render some view to show the result
            return View();
        }
    }
}
