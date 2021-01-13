using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MyFood.Models
{
    public class FoodDbContextFactory : IDesignTimeDbContextFactory<FoodDbContext>
    {
        public FoodDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();
           
            var connectionString = configuration.GetConnectionString("MyFoodDatabase");
           
            var optionsBuilder = new DbContextOptionsBuilder<FoodDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new FoodDbContext(optionsBuilder.Options);
        }
    }
}
