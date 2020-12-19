using Microsoft.AspNetCore.Mvc;

namespace Pierre.Controllers
{
  public class DogController : Controller
  {
    [HttpGet("/dogs")]
    public ActionResult Index()
    {
      return View();
    }
  }
}