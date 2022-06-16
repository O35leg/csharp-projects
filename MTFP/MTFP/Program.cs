using System;

namespace MTFP
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int N = Int32.Parse(Console.ReadLine());
			for (int i = 1; i <= N; i++)
			{
				double x = N / i; // 1.00

				if (isInt(x))
				{
					Console.WriteLine("Factor [{0}]", x);
				}
			}

			bool isInt(double a)
			{
				int b = (int)a;
				// a = 5.3; b = 5
				// a = 5.0; b = 5;

				double c = a - b;
				// a = 5.2; b = 5; c = 0.2;
				// a = 5; b = 5; c = 0;

				if (c > 0)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
		}
        }
    }

