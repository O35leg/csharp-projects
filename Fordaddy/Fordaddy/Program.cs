using System;

namespace Fordaddy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {



                if (i == 0)
                {
                    Console.WriteLine("|-------|");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|_______|");
                }

                if (i == 1)
                {
                    Console.WriteLine("|------------|");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|____________|");

                }

                if (i == 2)
                {
                    Console.WriteLine("|-------|");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|_______|");

                }

                if(i == 3)
                {
                    
                    break;
                }
            }
        }
    }
}
