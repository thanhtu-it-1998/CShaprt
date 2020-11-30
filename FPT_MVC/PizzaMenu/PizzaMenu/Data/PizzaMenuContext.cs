using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaMenu.Models;

namespace PizzaMenu.Data
{
    public class PizzaMenuContext : DbContext
    {
        public PizzaMenuContext (DbContextOptions<PizzaMenuContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaMenu.Models.Product> Product { get; set; }
    }
}
