using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 3;
            Calcullation obj = new Calcullation();
            Console.WriteLine($"Giai thua cua {val} la {obj.Factorial(val)}");
        }
        class Calcullation
        {
            public int Factorial(int value)
            {
                int result = 1;
                for (int index = 1; index <= value; index++)
                {
                    result = result * index;
                }
                return result;
            }
        }
    }
}
