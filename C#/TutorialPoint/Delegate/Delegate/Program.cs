using System;

namespace Delegate
{
    public delegate void NumberChange(int number);

    class Program
    {

        static int num = 10;
        static void Add(int ChangeNum)
        {
            num += ChangeNum;
        }
        static void Multi(int ChangeNum)
        {
            num *= ChangeNum;
        }
        static void Main(string[] args)
        {
            NumberChange nc1 = new NumberChange(Add);
            nc1(13);
            Console.WriteLine("Value of number : {0}", num);

            NumberChange nc2 = new NumberChange(Multi);
            nc2(20);
            Console.WriteLine("Value of number : {0}", num);

            Console.ReadKey();

        }
    }
}
