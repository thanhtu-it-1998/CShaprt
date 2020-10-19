using System;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int? intAge = null;
            float? floatMark = null;
            double? doublePrice = null;

            intAge = 30;
            Console.WriteLine($"Age: {intAge}");
            Console.WriteLine($"Mark: {floatMark??0}");
            Console.WriteLine($"Price: {doublePrice ?? 0 }");
        }
    }
}
