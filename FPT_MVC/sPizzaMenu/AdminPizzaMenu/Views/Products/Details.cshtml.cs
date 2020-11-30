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
    public class DetailsModel : PageModel
    {
        private readonly AdminPizzaMenu.Data.AdminPizzaMenuContext _context;

        public DetailsModel(AdminPizzaMenu.Data.AdminPizzaMenuContext context)
        {
            _context = context;
        }

        public ProductModel ProductModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductModel = await _context.ProductModel.FirstOrDefaultAsync(m => m.ProductId == id);

            if (ProductModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
