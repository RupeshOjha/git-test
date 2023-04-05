using Microsoft.AspNetCore.Mvc;

namespace MVCCoreWithViewController.Controllers
{
    public class HomeController : Controller
    {
    //userName: parameter
        public IActionResult Index(string userName, string country)
        {
            ViewBag.UserName = userName;
            return View();
        }
    }
}
