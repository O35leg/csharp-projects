using System;

namespace MTFP_MTPFP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: MTFP or MTPFP");

            string  MTPF = Console.ReadLine();

            if(MTPF == "MTFP")
            {
                MTFP();
            }
        }

       static void MTFP()
        {
            Console.WriteLine("Input a number. It's gonna figure all the factors of it.");
            int num = Int32.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                
                double Step1 = (double)num / i;
                double Step2 = (double)Step1 - (int)Step1;
               

                if(Step2 > 0)
                {
                    continue;
                }

                

                else if(Step2  == 0)
                 {
                            Console.WriteLine(i + " is  a facotr.");
                            continue;
                 }
                

                
            }
        }
    }
}
