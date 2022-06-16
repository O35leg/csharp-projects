using System;

namespace Averagefordaddy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.\n It will indicate how much times you want to enter the player's win rate. \n And then we'll calculate the average win rate of all players.");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ok. Now, Enter all the values(please round them to the nearest whole):");
            int sum = 0;
            for(int i = 0; i < num; i++)
            {
                int nums = Int32.Parse(Console.ReadLine());

                sum = sum + nums;

                

            
            }

            int result = sum / num;
            Console.WriteLine($"The result is [{result}]");


        }
    }
}
