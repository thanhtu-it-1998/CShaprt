using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session8.Models;

namespace Session8.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Get: Book/Create
        public IActionResult Create()
        {
            return View();
        }

        //Post: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Titile,RealaseDate,Cost")] BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(bookModel);
        }
    }
}
