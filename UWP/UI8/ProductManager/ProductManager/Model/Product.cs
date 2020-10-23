using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Model
{
   public class Product
    {
        public string ImagePathProduct { get; set; }
        public string NameProduct { get; set; }
        public string PriceProduct { get; set; }
        public string CategoryProduct { get; set; }
    }
    public class ListProduct
    {
        public static void GetAllProduct(ObservableCollection<Product> newsItems) {
            var filterNewsItems = getProducts().ToList();
            newsItems.Clear();
            filterNewsItems.ForEach(p => newsItems.Add(p));
        }

        public static void GetProductCategory( string category,ObservableCollection<Product> newsItems)
        {
            var allItems = getProducts();
            var filterNewsItems = allItems.Where(p => p.CategoryProduct == category).ToList();
            newsItems.Clear();

            filterNewsItems.ForEach(p => newsItems.Add(p));
        }
        public static List<Product> getProducts()
        {
            var items = new List<Product>();
            items.Add(new Product() { CategoryProduct = "Computer", ImagePathProduct = "/Assets/computer1.jpeg", NameProduct = "HP 348", PriceProduct = "490$" });
            items.Add(new Product() { CategoryProduct = "SmaxPhone", ImagePathProduct = "/Assets/smaxphone1.jpeg", NameProduct = "HP 348", PriceProduct = "490$" });
            items.Add(new Product() { CategoryProduct = "Television", ImagePathProduct = "/Assets/television1.jpeg", NameProduct = "HP 348", PriceProduct = "490$" });

            return items;
        }
    }
}
