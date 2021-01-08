using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestAzure.Models;


namespace TestAzure.Controllers
{
    public class HomeController : Controller
    {

        private TAzureRepository repository;
        public int PageSize = 4;
        public HomeController(TAzureRepository repo)
        {
            repository = repo;
        }

        //public IActionResult Index() => View(repository.Products);

        public ViewResult Index(int productPage = 1) 
          =>  View(repository.Products
                .OrderBy(p=>p.ProductID)
                .Skip((productPage-1)*PageSize)
                .Take(PageSize));
        
    }
}
