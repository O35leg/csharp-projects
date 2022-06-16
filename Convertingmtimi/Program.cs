using System;

namespace Convertingmtimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //coverting meters into miles(Made by my self)
            while (true)
            {
                int command = 9;
                int command2 = 9;

                Console.WriteLine("\n\nCommands:");
                Console.WriteLine("Press '0' to compare Pounds to Kilograms. ");
                Console.WriteLine("Press 1 to convet meters into Miles");
                Console.WriteLine("Press '2' to convert KM to miles");
                Console.WriteLine("Press '3' to convert KG to LB");
                command = Int32.Parse(Console.ReadLine());


                if (command == 0)
                {
                    command2 = 1;
                }

                if (command == 1)
                {
                    command2 = default;
                }

                if (command == 2)
                {
                    command2 = 2;
                }
                if (command == 3)
                {
                    command2 = 3;
                }


                switch (command2)
                {
                    case 1:

                        CompareLBtoKG();
                        break;

                    default:
                        default2();
                        break;

                    case 2:
                        kmtomiles();
                        break;

                    case 3:
                        CompareKGtoLB();
                        break;
                }



                static void CompareLBtoKG()
                {
                    double LB, KG;

                    Console.WriteLine("Please write a LB(pound) value");

                    LB = Double.Parse(Console.ReadLine());

                    KG = LB / 2.205;

                    Console.WriteLine("{0} pounds(LBS) is {1} kilograms", LB, KG);
                }

                static void CompareKGtoLB()
                {
                    double LB, KG;

                    Console.WriteLine("Please write a KG value");

                    KG = Double.Parse(Console.ReadLine());

                    LB = KG * 2.205;

                    Console.WriteLine("{1} KG is {0} LB", LB, KG);
                }

                static void default2()
                {
                    double meters, miles;
                    Console.WriteLine("Please enter a meter value");

                    meters = Double.Parse(Console.ReadLine());

                    miles = meters / 1609;

                    Console.WriteLine(meters + " is one " + miles + " of a mile");

                }

                static void kmtomiles()
                {
                    double KM, miles;
                    Console.WriteLine("Please enter a KM value");

                    KM = Double.Parse(Console.ReadLine());

                    miles = KM / 1.609;

                    Console.WriteLine(KM + " is one " + miles + " of a mile");

                }

            }
        }
      }
    }
 



//***************************************************************************
//converting fehranhites into celcius(dosen't work(Made by Me))

//double f, result;

//Console.WriteLine("This system is going to tell you the aproxamt covetation from Farenhites to Celcius.");
//Console.WriteLine("Enter a Farenhit value:");

//f = Double.Parse(Console.ReadLine());

//Console.WriteLine("Good. Now the program will compile it to Celsius");



//result = (f - 32) * (5 / 9);

//Console.WriteLine("{0} Franhiet is {1} Celsius", f, result);

//**************************************************************************
/////converting fehranhites into celcius( dosen't work(copied from book)
///




//double f, result;

//Console.WriteLine("This system is going to tell you the aproxamt covetation from Farenhites to Celcius.");
//Console.WriteLine("Enter a Farenhit value:");

//f = Double.Parse(Console.ReadLine());

//Console.WriteLine("Good. Now the program will compile it to Celsius");



//result =   5 / 9 * (f - 32);

//Console.WriteLine("{0} Franhiet is {1} Celsius", f, result);




