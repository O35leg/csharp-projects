using System;

namespace Frankdle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Frankdle Alpha";
            Console.ForegroundColor = ConsoleColor.DarkBlue; 
           Random wordgen = new Random(Guid.NewGuid().GetHashCode());
            string[] classfavouritewords = { "Information", "Inventory", "Exellent", "Soulution", "Soulution", "Symbols", "Son", "Daughter", "Bruh", "Stuff"};
            foreach(string g in classfavouritewords)
            {
                Console.WriteLine("All the words are " + g);
            }
            string outPutWord = classfavouritewords[wordgen.Next(0, 9)];
            Console.WriteLine("You will have 10000 chances to guess the word(I'm too lazy to write a normal loop system)");
            for(int i = 0; i < 100000; i++)
            {
                string guess = Console.ReadLine();

                if(guess == outPutWord)
                {
                    Console.WriteLine($"You made it! The word was [{outPutWord}]");
                    break;
                }
                else
                {
                    Console.WriteLine("Nope.");
                }
            }
        }
    }
}
