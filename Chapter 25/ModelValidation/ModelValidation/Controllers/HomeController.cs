using System;
using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers {
    public class HomeController : Controller {

        public ViewResult MakeBooking() {
            return View(new Appointment { Date = DateTime.Now });
        }

        [HttpPost]
        public ViewResult MakeBooking(Appointment appt) {
            if (ModelState.IsValid) {
                // statements to store new Appointment in a
                // repository would go here in a real project
                return View("Completed", appt);
            } else {
                return View();
            }
        }

        public JsonResult ValidateDate(string Date) {
            DateTime parsedDate;

            if (!DateTime.TryParse(Date, out parsedDate)) {
                return Json("Please enter a valid date (mm/dd/yyyy)",
                    JsonRequestBehavior.AllowGet);
            } else if (DateTime.Now > parsedDate) {
                return Json("Please enter a date in the future",
                    JsonRequestBehavior.AllowGet);
            } else {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }


    }
}
