using System;

namespace Forms.exe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("pls input stuff you *****");
            for (int i = 0; i < 10; i++)
            {
                int gonnabestoredsomewhere = Int32.Parse(Console.ReadLine());
                int[] yesitwillbestoredsomewhere = { gonnabestoredsomewhere };


                while (i == 9)
                {
                    foreach (int dumbass in yesitwillbestoredsomewhere)
                    {
                        Console.WriteLine("This is wat u inputed: [{0}]", dumbass);
                    }
                }

                
                


            }

            

        }
    }
}
