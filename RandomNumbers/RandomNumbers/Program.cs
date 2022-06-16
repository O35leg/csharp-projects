using System;

namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Rnd =  new Random(Guid.NewGuid().GetHashCode());
            Console.WriteLine("Imput a number(A whole(you can input the number 10 times))");
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine("Imput a number(A whole)");
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Now the system will input a compleatly random number from 0 to the number u entered. Here it is:");
                Console.WriteLine(Rnd.Next(0, number));
            }
        }
    }
}
