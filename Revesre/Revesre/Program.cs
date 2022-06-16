using System;

namespace Revesre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x, x1, x2;
            Console.WriteLine("Type in a three string(s):");
            x = Console.ReadLine();
            x1 = Console.ReadLine();
            x2 = Console.ReadLine();


            string[] combinedRev = { x2, x1, x};
            //Console.WriteLine("The reversed of what u wrote is here:");
            //Console.WriteLine(combinedRev); 
            foreach(string rev in combinedRev)
            {
               
                Console.WriteLine("\n \n" + rev);
            }
        }
    }
}
