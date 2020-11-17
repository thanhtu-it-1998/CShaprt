using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            AppMessage obj = new AppMessage
            {
                Message = "Hello Thanh Tu",
            };
            return View(obj);
        }

        [HttpPost]
        public ActionResult Index(AppMessage obj)
        {
            ViewBag.View = "Change Page Home";
            return View(obj);
        }
    }
}