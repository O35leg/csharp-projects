using System;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 0; i < 1000000; i = i + 2)
            // {
            //    Console.WriteLine(i);
            //  }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
