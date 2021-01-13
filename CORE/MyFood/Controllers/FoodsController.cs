using Microsoft.AspNetCore.Mvc;
using MyFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFood.Controllers
{
    public class FoodsController : Controller
    {
        private readonly FoodDbContext _context;
        public  FoodsController (FoodDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var foods = _context.Foods.Find();
            return View(foods);
        }
    }
}
