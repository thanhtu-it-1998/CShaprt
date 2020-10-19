using System;

namespace ArrayType
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 6, 5, 6, 7, 8 };
            Calculation obj = new Calculation();
            float value = obj.AnvengerArray(arr);
            Console.WriteLine(value);
        }
        public class Calculation
        {
            public float AnvengerArray(int[] arr)
            {
                int sum = 0;
                for (int index = 0; index < arr.Length; index++)
                {
                    sum += sum + arr[index];
                }
                float avg = sum / arr.Length;

                return avg;
            }
        }
    }
}
