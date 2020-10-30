using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Category.Add(a));
            GetProducts().ForEach(c => context.Product.Add(a));
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID=1,
                    ProductName="Computer",
                    Description="This convertiable car is fast! the engin is",
                    ImagePath="computer3.jpeg",
                    UnitPrice=34,
                    CategoryID=1
                }
            };
            return products;
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID=1,
                    CategoryName="Computer"

                }
            };
            return categories;
        }
    }
}