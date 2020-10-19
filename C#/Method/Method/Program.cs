using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcullation obj = new Calcullation();
            //int value = obj.FindMax(2, 4);
            //Console.WriteLine(value);
            //Console.WriteLine($" num1 = {8}: truoc khi doi,num2 = {5}:truoc khi doi");
            //obj.Swap(8, 5);\
            int value;
            obj.GetValue(out value);
            Console.WriteLine(value);

        }
        public class Calcullation
        {
            public int FindMax(int intNum1, int intNum2)
            {
                int result;
                if (intNum1 > intNum2)
                    result = intNum1;
                else
                    result = intNum2;
                return result;
            }

            public void Swap(int intNum1, int intNum2)
            {
                int result;
                result = intNum1;
                intNum1 = intNum2;
                intNum2 = result;
                Console.WriteLine($" num1 = {intNum1}: sau khi doi,num2 = {intNum2}:sau khi doi");
            }
            public void GetValue(out int a)
            {
                int value = 8;
                a = value;
            }
        }

    }
}
