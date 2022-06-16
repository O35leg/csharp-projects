using System;

namespace ComandLineBoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Thunderbeg";
            Console.ForegroundColor = ConsoleColor.Blue;

            string[] commands = { "!showAdmin&!", "!TypeFor!" };
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("IF you're the admin, please enter a special code(It will only work for right now).");
            string stuff = Console.ReadLine();
            if (stuff == "!showAdmin!")
            {
                Console.WriteLine("Turns out {0}, you're the admin!", name);
            }
            else
            {
                Console.WriteLine("Nope.");
            }

           

           


            
        }
    }
}
