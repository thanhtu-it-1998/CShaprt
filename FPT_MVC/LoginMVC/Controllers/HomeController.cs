using Microsoft.AspNetCore.Mvc;
using LoginMVC.Models;

namespace LoginMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AppMessage obj = new AppMessage
            {
                UserName = "Login"

            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(AppMessage obj)
        {
            ViewBag.Message = "Message Chaned";
            return View(obj);
        }
    }
}
