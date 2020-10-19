using System;
using System.Linq;
namespace Event
{
    public delegate void PriceChangeHandler(decimal oldPrice, decimal newPrice);

    class Product
    {
        private decimal _price;
        public event PriceChangeHandler PriceChanged;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price == value)
                {
                    return;
                }
                decimal oldPrice = _price;
                _price = value;
                if (PriceChanged != null)
                {
                    PriceChanged(oldPrice, _price);
                }
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Product objProduct = new Product();
            objProduct.Price = 1500;
            objProduct.PriceChanged += ProductChangePrice;
            objProduct.Price = 3500;

            Console.ReadLine();
        }
        public static void ProductChangePrice(decimal oldPrice, decimal newPrice)
        {
            Console.WriteLine("Old price:{0}", oldPrice);
            Console.WriteLine("New price:{0}", newPrice);
        }
    }
}
