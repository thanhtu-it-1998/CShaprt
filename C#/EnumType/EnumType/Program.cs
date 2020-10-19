using EnumType.Enum;
using System;

namespace EnumType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your role: ");
            string input = Console.ReadLine();

            if ((int)Role.Adminstratorm == int.Parse(input))
            {
                Console.WriteLine("Your role name: " + Role.Adminstratorm.ToString());
            }
            if ((int)Role.Editor== int.Parse(input))
            {
                Console.WriteLine("Your role name: " + Role.Editor.ToString());
            }
            if ((int)Role.Member == int.Parse(input))
            {
                Console.WriteLine("Your role name: " + Role.Member.ToString());
            }
            if ((int)Role.Moderator== int.Parse(input))
            {
                Console.WriteLine("Your role name: " + Role.Moderator.ToString());
            }
        }

    }
}
