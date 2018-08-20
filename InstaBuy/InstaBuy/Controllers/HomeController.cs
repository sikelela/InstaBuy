using System.Web.Mvc;

namespace InstaBuy.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Welcome to Insta Buy";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Contact Details";

      return View();
    }
  }
}