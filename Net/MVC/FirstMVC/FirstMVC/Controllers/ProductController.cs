using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class ProductController : Controller
    {
        ////// GET: Product
        //public actionresult index()
        //{
        //    return View();
        //}
        public string Product(string name, string category, int id) {
            return HttpUtility.HtmlEncode("Name: " + name + ", Category: " + category + ", ID: " + id) ;
        }
    }
}