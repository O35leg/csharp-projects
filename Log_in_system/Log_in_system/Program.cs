using System;

namespace Log_in_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void enterPWD()
            {
                Console.WriteLine("Hello World! Input a password for further use.") ;
                string pwd = Console.ReadLine();
                Console.WriteLine("Awesome! Pls input ‘Q’ or ‘q’ to logout.");

                string logout = Console.ReadLine();

                if (logout == "Q" || logout == "q")
{
                logouts();
            }

else
            {
                Console.WriteLine("Nope.");
            }

        }

        void logouts()
        {
            Console.WriteLine("Noice.Press ‘C’ or ‘c’ to continues  ");
            string continues = Console.ReadLine();

            if (continues == "C" || continues == "c")
{
                Console.WriteLine("Awesome! Now you’re gonna enter that pwd that you entered last time! It’s helps us see if u’re a bot;");

                pwdAgain();
            }
        }

        void pwdAgain()
        {
            Console.WriteLine("If u succeed, it means u’re not a bot!!!");
            string pwdsAgain = Console.ReadLine();

            if (pwdsAgain == pwd)
            {
                Console.WriteLine("Congrats!!");
            }

            else
        {
                Console.WriteLine("Get out bot!!!");
            }
        }

    }
}
}
