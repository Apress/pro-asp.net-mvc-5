using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Controllers {

    public class AdminController : Controller {
        private IProductRepository repository;

        public AdminController(IProductRepository repo) {
            repository = repo;
        }

        public ActionResult Index() {
            return View(repository.Products);
        }

        public ActionResult Edit(int productId) {
            Product product = 
                repository.Products.FirstOrDefault(p => p.ProductID == productId);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product) {
            if (!ModelState.IsValid) {
              // there is something wrong with the data values
              return View(product);
            }

            repository.SaveProduct(product);
            TempData["message"] = $"{product.Name} has been saved";
            return RedirectToAction("Index");
        }

        public ActionResult Create() {
            return View("Edit", new Product());
        }

        [HttpPost]
        public ActionResult Delete(int productId) {
            Product deletedProduct = repository.DeleteProduct(productId);
            if (deletedProduct != null) {
                TempData["message"] = $"{deletedProduct.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
