using System;

namespace LittleStory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Thunderflow";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WindowHeight = 40;
            //Console.BackgroundColor = ConsoleColor.DarkGray;
           

            Console.WriteLine("You woke up in a car.");
            Console.WriteLine("A person asked you for your name: ");
            //Console.WriteLine("What's you name?");
            
            string aa = Console.ReadLine();

            Console.WriteLine("You answered {0}.", aa);


            Console.WriteLine(" He said: Hello {0}, my name is Paul. \n Nice to meat you.\n We need to hide.", aa);
            Console.WriteLine("You were listening to him, but something caught your attension.");
            Console.WriteLine("// type a name of an animal");
            string bb = Console.ReadLine();
            Console.WriteLine("It was a {0}. It was an evil {0}", bb);
            Console.WriteLine("//type your emotions");
            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("He saw the {0} too.", bb);
            Console.WriteLine("He scremed: Run! It's a {0}!", bb);
            Console.ReadLine();
            Console.WriteLine("But he igored you.");
            Console.WriteLine("Ru...");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The {0} ate him. ", bb);
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("The {0} was going after you", bb);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("But it was too late. The {0} ate you.", bb);

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("The end!");







        }
    }
}
