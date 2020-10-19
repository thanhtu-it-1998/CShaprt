using System;
using System.IO;

namespace BinaryWR
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = "asdhfksadjhf";
            byte byteB = 12;
            double doubleC = 11.12;

            BinaryWriter bw = new BinaryWriter(new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite));

            try
            {
                bw.Write(strA);
                bw.Write(byteB);
                bw.Write(doubleC);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            bw.Close();
            BinaryReader br = new BinaryReader (new FileStream("data.txt", FileMode.Open, FileAccess.Read));
          
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadByte());

            Console.WriteLine("Save ok");
            Console.ReadKey();
            br.Close();
        }
    }
}
