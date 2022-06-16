using System;

namespace GG
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, lastName, result;
            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.Write("Enter your last name:");
            lastName = Console.ReadLine();

            result = name + "" + lastName;

            Console.WriteLine("Hello " + result + ",it's a plesure to meet u!");
        }
    }
}
