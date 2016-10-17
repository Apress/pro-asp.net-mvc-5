using System.Web;
using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ProfileAllAttribute());
        }
    }
}
