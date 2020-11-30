using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdminPizzaMenu.Data;
using AdminPizzaMenu.Models;

namespace AdminPizzaMenu.Views.Products
{
    public class IndexModel : PageModel
    {
        private readonly AdminPizzaMenu.Data.AdminPizzaMenuContext _context;

        public IndexModel(AdminPizzaMenu.Data.AdminPizzaMenuContext context)
        {
            _context = context;
        }

        public IList<ProductModel> ProductModel { get;set; }

        public async Task OnGetAsync()
        {
            ProductModel = await _context.ProductModel.ToListAsync();
        }
    }
}
