using System;

namespace GuessingGameWithRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a guessing game. It will give you hints. Random numbers from 0 1000.");
            Random NumberGenerator = new Random(Guid.NewGuid().GetHashCode());
            int Number = NumberGenerator.Next(0, 10001);
            Console.WriteLine("You have 10000 chances to guess. It's kinda easy, isn't it?! Remember, 0 through 1000!");
            for(int i = 0;i < 10001; i++)
            {
                int NumberGuess = Int32.Parse(Console.ReadLine());
                if(Number < 500)
                {
                    Console.WriteLine("The number is less 500.");
                    if(Number < 200)
                    {
                        Console.WriteLine("The number is also lesser than 200.");
                        if(Number < 100)
                        {
                            Console.WriteLine("The number is lesser than 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The number is less than 500, but greater than 200.");
                    }
                }

                if (Number > 500)
                {
                    Console.WriteLine("The number is greater than 500.");
                    if(Number > 700)
                    {
                        Console.WriteLine("The number is greater than 700.");
                        if(Number > 900)
                        {
                            Console.WriteLine("It's greater than 900.");
                        }
                        else
                        {
                            Console.WriteLine("It's greater than 700, but less than 900.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("It's greater than 500, but less than 700.");
                    }
                }

                if(NumberGuess == Number)
                {
                    Console.WriteLine("You got it!");
                    break;
                    
                }
            }
            
        }
    }
}
