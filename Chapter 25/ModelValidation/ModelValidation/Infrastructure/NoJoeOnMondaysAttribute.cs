using System;
using System.ComponentModel.DataAnnotations;
using ModelValidation.Models;

namespace ModelValidation.Infrastructure {
    public class NoJoeOnMondaysAttribute : ValidationAttribute {

        public NoJoeOnMondaysAttribute() {
            ErrorMessage = "Joe cannot book appointments on Mondays";
        }

        public override bool IsValid(object value) {
            Appointment app = value as Appointment;
            if (app == null || string.IsNullOrEmpty(app.ClientName) ||
                    app.Date == null) {
                // I don't have a model of the right type to validate, or I don't have
                // the values for the ClientName and Date properties I require
                return true;
            } else {
                return !(app.ClientName == "Joe" &&
                    app.Date.DayOfWeek == DayOfWeek.Monday);
            }
        }
    }
}
