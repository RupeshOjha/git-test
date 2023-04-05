using Microsoft.AspNetCore.Mvc;

namespace MVCCoreWithViewController.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string userName, string country)
        {
            ViewBag.UserName = userName;
            return View();
        }
    }
}
