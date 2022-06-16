using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Please input different types of shapes. U can pick from: Triangle , Circle, Square, Rectagle.");
                string shapeSelector =  Console.ReadLine();

                if(shapeSelector == "Square")
                {
                    Console.WriteLine("\n|------|");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      |");
                     Console.WriteLine("-------");
                }

                if(shapeSelector == "Circle")
                {
                    Console.WriteLine("\n() ");
                }

                if (shapeSelector == "Triangle")
                {
                    Console.WriteLine("/|");
                   Console.WriteLine("/ |");
                  Console.WriteLine("/  |");
                 Console.WriteLine("/   |");
                Console.WriteLine(" -----");
                }

                if(shapeSelector == "Rectangle")
                {
                    Console.WriteLine("|--------|");
                    Console.WriteLine("|________|");
                }

                else if(shapeSelector != "Rectangle" && shapeSelector != "Triangle" && shapeSelector != "Circle" && shapeSelector != "Square")
                {
                    Console.WriteLine("\nSyntax error: No shape like this in the system. Try agian");
                }
            }
        }
    }
}
