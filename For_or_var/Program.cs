using System;

namespace For_or_var
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WindowHeight = 40;
            Console.WindowWidth = 150;
            Console.Title = "ThunderFlow";
            Console.WriteLine("Type in a sentence as long as you want, when you don't type anything, the program will put it into arrays(I'll sue you).And don't right the m-word!");


            //Console.Write("Type in the first word:");

            //string aa = Console.ReadLine();


            //Console.Write("Type in the second word:");
            //string bb = Console.ReadLine();
            //Console.Write("Type in the third word:");
            //string cc = Console.ReadLine();
            //Console.Write("Type in the fourth and last word:");
            //string pp = Console.ReadLine();



            //string[] words = { aa, bb, cc, pp };


            //for (; ; )
            //{
            //   string aa =  Console.ReadLine();

            //    if (aa == "")
            //    {
            //        Console.Write("You entered [{0}]." ,aa);
            //        //Console.Write("You're done! Get out! go! go! shooooo! " + "you shall pay for that!");
            //        break;
            //    }

            string[] container = new string[10];
            for(int i = 0; i < 10; i++)
            {
                string aa =  Console.ReadLine();
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
            foreach( string elem in container )
            {
                Console.WriteLine("Element [{0}] = [{1}]", ii++, elem);
               
            }

            Console.WriteLine(container);
            //double num1;
            //double num2;
            //double num3;

            //Console.Write("Type in a number:");

            //num1 = Convert.ToDouble(Console.ReadLine());



            //else
            //{
            //    for (; ; )
            //    {
            //     aa = Console.ReadLine();
            //    }
            //}
        }
            //string aa = Console.ReadLine();
            

            //Console.WriteLine("Your first word was [{0}]. You second word was [{1}]. Your third word was [{2}]. Your fourth and last word was [{3}]", aa, bb, cc, pp);


            //if ( inputfield == "")
            //{
            
            //}
            
            ///The "Console and Var 'quiz'" is done. The program later you'll read is al about For loops AKA banana go weee.
            //

        }
    }

//  4-

