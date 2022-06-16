using System;

namespace Calcualtor.exe
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello boi! \nThis is a calculator. \nInput any number and basic operation. \nLet's start with the first number:");
            for (; ; )
            {
                double result;
                double firstNum = Double.Parse(Console.ReadLine());
                Console.WriteLine("Input a second number:");
                double secondNum = Double.Parse(Console.ReadLine());
                Console.WriteLine("Now the operation");
                string operationBeepBeep = Console.ReadLine();

                if (operationBeepBeep == "/" && secondNum == 0)
                {
                    Console.WriteLine("Syntax error: Can't divide by 0.");
                }

                 else if (operationBeepBeep == "/")
                {
                    result = firstNum / secondNum;
                    Console.WriteLine("The result is [{0}]", result);
                }

                

                if (operationBeepBeep == "-")
                {
                    result = firstNum - secondNum;
                }

                if (operationBeepBeep == "+")
                {
                    result = firstNum + secondNum;
                }

                if (operationBeepBeep == "*")
                {
                    result = firstNum * secondNum;
                }

                else if (operationBeepBeep != "/" && operationBeepBeep != "*" && operationBeepBeep != "+" && operationBeepBeep != "-")
                {
                    Console.WriteLine("No such operation like this.");
                    break;
                }


            }

        }
    }
}
