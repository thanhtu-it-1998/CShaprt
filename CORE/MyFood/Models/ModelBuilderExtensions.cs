using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFood.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData(
                new Food()
                {
                    ID = 1,
                    Image = "cherries.jpg",
                    Title = "The Perfect Sandwich, A Real NYC Classic",
                    Description = "Just some random text, lorem ipsum text praesent tincidunt ipsum lipsum."
                },
                new Food()
                {
                    ID = 2,
                    Image = "croissant.jpg",
                    Title = "Let Me Tell You About This Steak",
                    Description = "Once again, some random text to lorem lorem lorem lorem ipsum text praesent tincidunt ipsum lipsum."
                },
                new Food()
                {
                    ID = 3,
                    Image = "popsicle.jpg",
                    Title = "Cherries, interrupted",
                    Description = "Lorem ipsum text praesent tincidunt ipsum lipsum.What else? "
                },
                new Food()
                {
                    ID = 4,
                    Image = "salmon.jpg",
                    Title = "Once Again, Robust Wine and Vegetable Pasta",
                    Description = "Lorem ipsum text praesent tincidunt ipsum lipsum."
                }, new Food()
                {
                    ID = 5,
                    Image = "sandwich (1).jpg",
                    Title = "All I Need Is a Popsicle",
                    Description = "Lorem ipsum text praesent tincidunt ipsum lipsum.What else? "
                }, new Food()
                {
                    ID = 6,
                    Image = "sandwich.jpg",
                    Title = "Salmon For Your Skin",
                    Description = "Once again, some random text to lorem lorem lorem lorem ipsum text praesent tincidunt ipsum lipsum."
                }, new Food()
                {
                    ID = 7,
                    Image = "steak.jpg",
                    Title = "The Perfect Sandwich, A Real Classic",
                    Description = "Just some random text, lorem ipsum text praesent tincidunt ipsum lipsum."
                }, new Food()
                {
                    ID = 8,
                    Image = "wine.jpg",
                    Title = "Le French",
                    Description = "Lorem ipsum text praesent tincidunt ipsum lipsum.What else? "
                }
                );
        }
    }
}
