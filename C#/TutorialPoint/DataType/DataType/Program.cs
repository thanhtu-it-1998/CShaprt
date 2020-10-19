using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Size of int: {0}", sizeof(int));
            //Console.WriteLine("Size of double: {0}", sizeof(double));
            //Console.WriteLine("Size of float: {0}", sizeof(float));
            //Console.WriteLine("Size of byte: {0}", sizeof(byte));
            //Console.ReadLine();
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}
