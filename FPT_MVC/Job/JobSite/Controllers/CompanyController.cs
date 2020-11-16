using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobLibrary;
using JobLibrary.DAL;

namespace JobSite.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            JobsDbEntities1 company = new JobsDbEntities1();
            CompanyDAL companyDAL = new JobLibrary.DAL.CompanyDAL(company);
            List<JobLibrary.Company> companyList = companyDAL.GetCompanies();
            return View(companyList);
        }
    }
}