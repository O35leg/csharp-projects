using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Thunderflow";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WindowHeight = 40;

            double num1;
            double num2;
            double num3;

            Console.Write("Type in a number:");

            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type in a second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

           Console.Write("And finally, input a third number.");

            num3 = Convert.ToDouble(Console.ReadLine());

            double result = (num1 + num2 + num3) / 3;

            Console.WriteLine("The result is " + result);

            Console.WriteLine("Happy? Did we do anythng useful? If we did, please go to 0997udan.itch.io and leave a comment and play the game! Thank you!");


            

           

        }
    }
}
