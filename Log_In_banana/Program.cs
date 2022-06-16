using System;

namespace Log_In_banana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Typhoon";
            Console.WindowHeight = 40;
            Console.WindowWidth = 200;
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine("Password:");
            //Console.WriteLine("Press 'H' to continue.");
            string pwd = Console.ReadLine();

            if (pwd == "")
            {
                Console.WriteLine("Can't do that irl! Try again!");
            }

            if (pwd == pwd)
            {
                Console.WriteLine("Saved.");
                Console.WriteLine("Press H to log out.");
            }
            string h = Console.ReadLine();

            if (h == "h")
            {
                Console.WriteLine("You've logged out.");
            }

            else {
                Console.WriteLine("Wrong Key. Try Again");
                Console.WriteLine("Try again:");
                Console.ReadLine();
            }

            if (h != "h")
            {
                Console.WriteLine("You have been banned.");
                Console.WriteLine("You're a bot.");
                
            }

            else
            {
                Console.WriteLine("You have succesfully logged out.");
                Console.WriteLine("Press 'D' to log in");
            }

            string login = Console.ReadLine();
            string pwds = pwd;

            if (login == "d")
            {
                Console.Write("Password:");
                Console.ReadLine();
            }

           if(pwd == pwd)
            {
                Console.WriteLine("Welcome!");
              
            }

            else
            {
                Console.WriteLine("Inccorect. Try Again.");
            }

            

        }
    }
}
