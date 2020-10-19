using System;
using System.IO;

namespace DirectoryAndFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo myDir = new DirectoryInfo(@"D:\Profile\"); 

            if(myDir.Exists)
            {
                FileInfo[] files= myDir.GetFiles();
                foreach(FileInfo file in files)
                {
                    Console.WriteLine(file.FullName);
                }
            }
            else
            {
                Console.WriteLine("DirectoryInfo is not exsts");
            }
            Console.ReadKey();
        }
    }
}
