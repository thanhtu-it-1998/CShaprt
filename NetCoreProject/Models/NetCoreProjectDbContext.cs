using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NetCoreProject.Models
{
    public class NetCoreProjectDbContext : DbContext
    {
        public NetCoreProjectDbContext(DbContextOptions<NetCoreProjectDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
