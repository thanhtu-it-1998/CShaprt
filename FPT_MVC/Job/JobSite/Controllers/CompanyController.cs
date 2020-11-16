using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobLibrary;
using JobLibrary.BLL;

namespace JobSite.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            JobsDbEntities company = new JobsDbEntities();
            CompanyBLL companyBusLayer = new CompanyBLL(company);
            List<Company> companyList = companyBusLayer.getPaged();
            return View(companyList);
        }
    }
}