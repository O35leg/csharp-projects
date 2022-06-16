using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] b = { "g", "Honda", "andRussia" };

            foreach(string i in b)
            {
                Console.WriteLine(i);

            }

            for (int i = 9; i < 16; i++) 
            {
                Console.WriteLine("I'm naked!!! aaaaaaaa! what the heck have you done!!!! ahhhhhhhh!");
            }

            int[] arr = { 3, 1, 2, 5, 6, 7, 8 };



            foreach (int i in arr)
            {
                
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            ///for(string i = "ggugtgtrt"; ///ummmm? )
        }
    }
}
