using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaMenu.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public decimal SizeS { get; set; }
        public decimal SizeL { get; set; }
        public decimal SizeXL { get; set; }
        public byte[] Image { get; set; }
        public string UrlImage { get; set; }

    }
}
