using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)

        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);

            int guess = -1;

            Console.WriteLine("This is Prep 3");



            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                

                if(magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it right!");
                }
            }

           
        }
    }
}
