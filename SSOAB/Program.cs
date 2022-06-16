using System;

namespace SSOAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}, your going to take a little test on coding.", name);
            int date;
            Console.WriteLine("{0}, since I'm a machine, I want to ask you this: input today's day, year, month.", name);
            date = Int32.Parse(Console.ReadLine());
        }
    }
}
