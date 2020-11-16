using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {

        private readonly HospitalEntities _context = new HospitalEntities();
        public ActionResult Index()
        {
            var patients = _context.Patients.ToList();
            ViewData["Patients"] = _context.Patients.ToList().Count();
            return View(patients);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}