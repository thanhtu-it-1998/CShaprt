using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAzure.Models.DbContexts;

namespace TestAzure.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder app)
        {
            TAzureDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<TAzureDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name="Lamboghini", 
                        Price=375
                    },
                    new Product
                    {
                        Name = "Ferari",
                        Price = 400
                    },
                    new Product
                    {
                        Name = "Lexus",
                        Price = 75
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
