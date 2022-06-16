using System;

namespace Calculatorfordadsbirthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {


                //calculator
                Console.Write("This is a calaculator(with reals).\n Dad, happy Birhtday!!! \n I'm sorry I'm such a dumbass, couldn't give a normal present. \n Anyways, input an operation. You can choose from 'Addition', 'Subtraction', 'Multiplacation','Division' and 'dc'(or just choose the very first letter(accept 'dc' which stands for 'date calculation. Also, it's on the beta version, A.K.A doesn't work.' )). \n Go on:");



                string operation = Console.ReadLine();

                if(operation == "dc")
                {
                    CalculateDateDifference();
                }
                if (operation == "Addition" || operation == "A" || operation == "a")
                {
                    DoAddition();
                }

                if (operation == "Subtraction" || operation == "S" || operation == "s")
                {
                    Dosub();
                }

                if (operation == "Multiplacation" || operation == "M" || operation == "m")
                {
                    DoMultiplacation();
                }


                if (operation == "Division" || operation == "D" || operation == "d" )
                {
                    DoDivision();
                }

                //all functions are here
                void DoAddition()
                {
                    Console.WriteLine("Enter a number");
                    double num1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second one:");
                    double num2 = Double.Parse(Console.ReadLine());
                    double result = num2 + num1;
                    Console.WriteLine($"The result is [{result}]");

                }

                void Dosub()
                {
                    Console.WriteLine("Enter a number");
                    double num01 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second one:");
                    double num02 = Double.Parse(Console.ReadLine());
                    double result = num01 - num02;
                    Console.WriteLine($"The result is [{result}]");
                }


                void DoMultiplacation()
                {
                    Console.WriteLine("Enter a number");
                    double num0001 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second one:");
                    double num0002 = Double.Parse(Console.ReadLine());
                    double result = num0001 * num0002;
                    Console.WriteLine($"The result is [{result}]");
                }


                void DoDivision()
                {
                    Console.WriteLine("Enter a number");
                    double num001 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second one:");
                    double num002 = Double.Parse(Console.ReadLine());
                    double result = num001 / num002;
                    Console.WriteLine($"The result is [{result}]");
                }

                void CalculateDateDifference()
                {
                    Console.WriteLine("Enter a year: ");
                    int startYear = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a month: ");
                    int startMonth = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a day: ");
                    int startDay = Int32.Parse(Console.ReadLine());
                    DateTime Everycombinedstartdate = new DateTime(startYear, startMonth, startDay);
                    Console.WriteLine("Great! You've entered the starting date - now, enter a smaller one and we're gonna calculate the difference."); // 12/25/2015 12:00:00 AM    

                    Console.WriteLine("Enter a year: ");
                    int endYear = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a month: ");
                    int endMonth = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a day: ");
                    int endDay = Int32.Parse(Console.ReadLine());
                    DateTime Everycombinedenddate = new DateTime(endYear, endMonth, endDay);
                    TimeSpan result = Everycombinedstartdate.Subtract(Everycombinedenddate);
                    Console.WriteLine(result.ToString());
                }

            }
        }
    }
}
