using System;

namespace Loginbananaboipls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Thunderflow's";
            Console.ForegroundColor = ConsoleColor.Blue;

            string[] commands = {"$PrintMessageHello!", "$LogInAdmin!!!", "$Insertin.lines!", "$Make15Lines!"};

            Console.WriteLine("Welcome to Thunderflow's commandline.\n Type in a command to start:");

           

            var aa = Console.ReadLine();

            if(aa == "$PrintMessageHello!")
            {
                Console.WriteLine("Hello, World!");
            }

            else if(aa == "$LogInAdmin!!!")
            {
                Console.WriteLine("Oleg");
            }

            else if (aa == "$Makevariable!")
            {
                
                Console.WriteLine("Ok. We're going to add these two variables. Write your variable here:");
                string b = Console.ReadLine();
                Console.WriteLine("You inputed {0}.", b);
                Console.WriteLine("Input a second variable:");
                string bb = Console.ReadLine();
                int resualt;
                resualt = b + bb;
                Console.WriteLine("You result was {0}", resualt);
            }

            else
            {
                Console.WriteLine("Command not found.");
            }

            

        }
    }
}
