using System;

namespace Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] container = new string[10];
            for (int i = 0; i < 10; i++)
            {
                string aa = Console.ReadLine();
                //double[] bb;

                //bb = Convert.ToDouble(Console.ReadLine());

                if (aa == "")
                {
                    //Console.WriteLine("You inputed: [{0}]", aa);
                    break;
                }

                container[i] = aa;
            }

            int ii = 0;
            foreach (string elem in container)
            {
                Console.WriteLine("Element [{0}] = [{1}]", ii++, elem);

            }

            Console.WriteLine(container);
        }
    }
}
