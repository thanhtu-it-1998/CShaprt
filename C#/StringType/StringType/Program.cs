using System;
using System.Collections.Generic;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strNames = new List<string> { "Ngoc", "Ha", "Chi", "Linh", "Hoa", "Loi" };
            Console.WriteLine("Hay Nhap Ten Cua Ban: = ");
            string strName = Console.ReadLine();
            Calculation objCal = new Calculation();
            objCal.AddStaff(strNames, strName);

        }

        public class Calculation
        {
            public void AddStaff(List<string> strNames, string strName)
            {
                strNames.Add(strName);
                for (int index = 0; index < strNames.Count; index++)
                {
                    if (index == 0) Console.WriteLine("Lop ta hien co: ");
                    if (index < (strNames.Count - 1)) Console.Write(strNames[index] + ", ");
                    if (strNames[index] == strName) Console.WriteLine("Co the thanh vien moi: " + strName);
                }
            }
        }
    }
}
