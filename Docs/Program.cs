using System;

namespace Docs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FishingROD's Docs";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("This is a program with infite lines, cool colours, and much more. Of course, ou can already type stuff. Press 'Q' to exit(The upercase one).");

            for(; ; )
            {
                string queuenotreally;
                queuenotreally =  Console.ReadLine();
                if (queuenotreally == "Q")
                {
                    break;
                }
            };
        }
    }
}
