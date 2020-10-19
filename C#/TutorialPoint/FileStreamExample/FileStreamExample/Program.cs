using System;
using System.IO;

namespace FileStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            String input = Console.ReadLine();

            string filePath = "data.txt";
            using (StreamWriter sw = new StreamWriter(filePath,true))
            {
                sw.WriteLine(input);
            };

            Console.WriteLine("Your name was enter. Do you want to reat it: YEs/No");

            string choise = Console.ReadLine();

            if ("Y".Equals(choise))
            {
                string data = string.Empty;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((data = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
