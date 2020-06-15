using Microsoft.AspNetCore.Mvc;

namespace NEHO.VABombers.Web.Controllers
{
  public class AppController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {

      ViewBag.Title = "Home Page";

      return View();
    }

    [HttpGet("contact")]
    public IActionResult Contact()
    {
      ViewBag.Title = "Contact Us";

      return View();
    }

    [HttpGet("about")]
    public IActionResult About()
    {
      ViewBag.Title = "About Us";

      return View();
    }
  }
}