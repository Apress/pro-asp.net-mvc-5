using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Filters.Infrastructure {

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,
        Inherited = true, AllowMultiple = false)]
    public class CustomOverrideActionFiltersAttribute : FilterAttribute,
            IOverrideFilter {
        public Type FiltersToOverride {
            get { return typeof(IActionFilter); }
        }
    }
}
