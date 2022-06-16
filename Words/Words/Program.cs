using System;

namespace Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
               
                for (int loops = 0; loops < 3; loops++)
                {
                    string word, word1, word2;
                    string[] badWords = { "Fuck", "fuck", "shit", "Shit", "ass", "Ass" };
                    Console.WriteLine("You have three chancess to enter words. Don't type bad words.");

                    Console.WriteLine("Type in a word:");
                    word = Console.ReadLine();
                    if (word == badWords[loops])
                    {
                        Console.WriteLine("You entered [_]");
                    }
                    else
                    {
                        Console.WriteLine("U entered {0}", word);
                    }
                    

             }
        }
    }
}
