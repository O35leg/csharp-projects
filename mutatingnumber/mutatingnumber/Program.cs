using System;

namespace mutatingnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Number = new Random(Guid.NewGuid().GetHashCode());

            Console.WriteLine("Enter a number(this program will put it in a loop. It will generate the number 0. \n Then, it will mutate the number of times the number will be worth(too awoid lagging, the number will be up to a thousand.");

            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The numbers is 0;");
            for(int i = 0; i < number; i++)
            {
                int randomInt = Number.Next(0, 1001);
                Console.WriteLine("The number is [{0}];", randomInt);  
            }
        }
    }
}
