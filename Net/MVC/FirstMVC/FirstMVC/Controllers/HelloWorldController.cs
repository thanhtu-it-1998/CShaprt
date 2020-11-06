using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        //// GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index( )
        {
            return "<h1>Thanh Tu Dep Trai </h1>";
        }

        //public string welCome()
        //{
        //    return "Xin Chao";
        //}

        public string Welcome(string name ,int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID:" + ID);
        }
    }
}