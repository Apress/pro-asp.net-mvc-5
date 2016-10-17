using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes {
    public class RouteConfig {

        public static void RegisterRoutes(RouteCollection routes) {

            routes.RouteExistingFiles = true;

            routes.MapMvcAttributeRoutes();

            routes.IgnoreRoute("Content/{filename}.html");

            routes.Add(new Route("SayHello", new CustomRouteHandler()));

            routes.Add(new LegacyRoute(
                    "~/articles/Windows_3.1_Overview.html",
                    "~/old/.NET_1.0_Class_Library"));

            routes.MapRoute("MyRoute", "{controller}/{action}", null,
                new[] { "UrlsAndRoutes.Controllers" });
            routes.MapRoute("MyOtherRoute", "App/{action}", new { controller = "Home" },
                new[] { "UrlsAndRoutes.Controllers" });
        }
    }
}
