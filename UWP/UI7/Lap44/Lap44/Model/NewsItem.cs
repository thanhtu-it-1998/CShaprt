using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap44.Model
{
    public class NewsItem
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }
    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();
            var filterNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();

            filterNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();
            items.Add(new NewsItem() { ID = 1, Category = "Financial", Headline = "Lorem Impsum", Subhead = "doro sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/StoreLogo.png" });
            items.Add(new NewsItem() { ID = 2, Category = "Financial", Headline = "Lorem Impsum", Subhead = "doro sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/StoreLogo.png" });
            items.Add(new NewsItem() { ID = 3, Category = "Financial", Headline = "Lorem Impsum", Subhead = "doro sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/StoreLogo.png" });
            items.Add(new NewsItem() { ID = 4, Category = "Financial", Headline = "Lorem Impsum", Subhead = "doro sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/StoreLogo.png" });
            items.Add(new NewsItem() { ID = 5, Category = "Financial", Headline = "Lorem Impsum", Subhead = "doro sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/StoreLogo.png" });
            items.Add(new NewsItem() { ID = 6, Category = "Food", Headline = "Lorem Impsum", Subhead = "doro sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/StoreLogo.png" });
            items.Add(new NewsItem() { ID = 7, Category = "Food", Headline = "Lorem Impsum", Subhead = "doro sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/StoreLogo.png" });
            items.Add(new NewsItem() { ID = 8, Category = "Food", Headline = "Lorem Impsum", Subhead = "doro sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/StoreLogo.png" });
            return items;
        }
    }
}
