using System;

namespace AverageWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please decide how many people you're going to enter:");
            int howManyPeople = Int32.Parse(Console.ReadLine());
            
            int[] arr = new int[howManyPeople];
            for(int i = 0; i < howManyPeople; i++)
            {
              int x = Int32.Parse(Console.ReadLine());
              arr[i] = x;
                //while (i <= howManyPeople)
                //{
                //    int av;
                //    av = x.Average();
                //}
            }

            //int sum = arr[0] + arr[1] + arr[2];

            //int sum2 = arr[0];
            //sum2 = sum2 + arr[1];
            //sum2 = sum2 + arr[2];

            int sum = 0;
            
            foreach (int x in arr)
            {
                sum = sum + x;
            }
            double result = sum / arr.Length;
            Console.WriteLine("The average is [{0}]", result);



            
        }
    }
}
