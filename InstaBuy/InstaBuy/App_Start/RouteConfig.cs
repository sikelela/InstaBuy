using System.Web.Mvc;
using System.Web.Routing;

namespace InstaBuy
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      routes.MapRoute(
          name: "Default",
          url: "{controller}/{action}/{id}",
          //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          defaults: new { controller = "Account", action = "Account", id = UrlParameter.Optional }
      );

      routes.MapMvcAttributeRoutes();
      /*
      routes.MapRoute(
        name: "OrdersByNumber",
        url: "orders/orderList/{pageIndex}/{sortby}",
        defaults: new { controller = "Orders", action = "OrderList" },
        constraints: new { pageIndex = @"\d{2}" }
        );
      */

      routes.MapRoute(
      name: "CustomerOrders",
      url: "orders/customerOrders",
      defaults: new { controller = "Orders", action = "CustomerOrders" }
      );

      routes.MapRoute(
        name: "Customer",
        url: "{controller}/{action}/{id}",
        defaults: new { controller = "Customer", action = "Index", id = UrlParameter.Optional }
      );

    }
  }
}
