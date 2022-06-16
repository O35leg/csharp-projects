using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteryournamefrombook
{
    class Program
    {
        static void Main()
        {
            string name, lastName, result;

            

            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.Write("Enter your last name:");
            lastName = Console.ReadLine();

            result = name + lastName;

            Console.WriteLine("Hello {0}, it's a plesure to meet u!", result);


        }
    }
}
