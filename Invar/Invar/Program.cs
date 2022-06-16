using System;

namespace Invar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {


                Console.WriteLine("Input a number.");
                int num = Int32.Parse(Console.ReadLine());

                bool Invar = false;
                if (num <= 500)
                {
                    Invar = true;

                }
                if (Invar == true)
                {
                    Console.WriteLine("your num is less" +
                        " than or equals to 500");
                }
                else if (num > 500)
                {
                    Invar = false;
                    Console.WriteLine("Num gretaer than 500");
                }
            }
        }
    }
}

