using System;

namespace Findsanaverage
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Title = "Average.exe";
                Console.WriteLine("\nPlease input two numbers(Including decimals).");
                double num01 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Awesome! Now input a second number:");
                double num02 = Double.Parse(Console.ReadLine());
                double result = (num01 + num02) / 2;
                Console.WriteLine("Nice. Here is the result: [{0}]", result);
                
               
                

            }
        }
    }
}
