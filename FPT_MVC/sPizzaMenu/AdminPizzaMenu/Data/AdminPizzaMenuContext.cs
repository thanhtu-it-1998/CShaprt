using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdminPizzaMenu.Models;

namespace AdminPizzaMenu.Data
{
    public class AdminPizzaMenuContext : DbContext
    {
        public AdminPizzaMenuContext (DbContextOptions<AdminPizzaMenuContext> options)
            : base(options)
        {
        }

        public DbSet<AdminPizzaMenu.Models.ProductModel> ProductModel { get; set; }
    }
}
