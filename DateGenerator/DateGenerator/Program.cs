using System;

namespace DateGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a date generator from the year 1000 to 3000.");
            for (int i = 0; i < 5; i++)
            {


                Random Rnd = new Random(Guid.NewGuid().GetHashCode());
                
                Console.WriteLine(Rnd.Next(1, 13) + "/" + Rnd.Next(1, 32) + "/" + Rnd.Next(1000, 3001));
            }
        }
    }
}
