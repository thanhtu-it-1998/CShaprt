using System;

namespace DotNetEventModel
{
    public class PriceChangeEventAgrs
    {
        public readonly decimal OldPrice;
        public readonly decimal NewPrice;

        public PriceChangeEventAgrs(decimal oldPrice,decimal newPrice)
        {
            this.OldPrice = oldPrice;
            this.NewPrice = newPrice;
        }
    }

    public delegate void PriceChangeHandler(object sender, PriceChangeEventAgrs e);

    class Product
    {
        public decimal _price;
        public void Ob
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
