using System.Web.Mvc;

namespace InstaBuy.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.User = "Sikelela";
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "An Online Fashion Store dedicated to delivereing the fashion you desire to your door.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Contact Details";

      return View();
    }
  }
}