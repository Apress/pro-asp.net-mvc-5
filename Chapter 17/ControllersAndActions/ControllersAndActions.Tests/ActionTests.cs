using System.Web.Mvc;
using ControllersAndActions.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControllersAndActions.Tests {
    [TestClass]
    public class ActionTests {

        [TestMethod]
        public void ControllerTest() {

            // Arrange - create the controller
            ExampleController target = new ExampleController();

            // Act - call the action method
            HttpStatusCodeResult result = target.StatusCode();

            // Assert - check the result
            Assert.AreEqual(401, result.StatusCode);
        } 






        [TestMethod]
        public void ViewSelectionTest() {

            // Arrange - create the controller
            ExampleController target = new ExampleController();

            // Act - call the action method
            ViewResult result = target.Index();

            // Assert - check the result
            Assert.AreEqual("", result.ViewName);
            Assert.IsInstanceOfType(result.ViewData.Model, typeof(System.DateTime));
        }
    }
}
