using System;
using System.Web.Mvc;

namespace Filters.Infrastructure {
    public class RangeExceptionAttribute : FilterAttribute, IExceptionFilter {

        public void OnException(ExceptionContext filterContext) {

            if (!filterContext.ExceptionHandled &&
                    filterContext.Exception is ArgumentOutOfRangeException) {

                int val = (int)(((ArgumentOutOfRangeException)
                    filterContext.Exception).ActualValue);
                filterContext.Result = new ViewResult {
                    ViewName = "RangeError",
                    ViewData = new ViewDataDictionary<int>(val)
                };
                filterContext.ExceptionHandled = true;
            }
        }
    }
}
