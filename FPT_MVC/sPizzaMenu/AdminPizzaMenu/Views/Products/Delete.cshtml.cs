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
    public class DeleteModel : PageModel
    {
        private readonly AdminPizzaMenu.Data.AdminPizzaMenuContext _context;

        public DeleteModel(AdminPizzaMenu.Data.AdminPizzaMenuContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductModel = await _context.ProductModel.FindAsync(id);

            if (ProductModel != null)
            {
                _context.ProductModel.Remove(ProductModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
