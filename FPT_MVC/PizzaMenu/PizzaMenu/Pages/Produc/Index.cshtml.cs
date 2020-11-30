﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaMenu.Data;
using PizzaMenu.Models;

namespace PizzaMenu.Pages.Produc
{
    public class IndexModel : PageModel
    {
        private readonly PizzaMenu.Data.PizzaMenuContext _context;

        public IndexModel(PizzaMenu.Data.PizzaMenuContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
