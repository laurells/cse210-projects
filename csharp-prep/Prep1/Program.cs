using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is prep 1");

            // Write your code here
            Console.Write("What is your first name? ");
            string name1 = Console.ReadLine();
            Console.Write("What is your last name? ");
            string name2 = Console.ReadLine();
            Console.WriteLine($"Your name is {name2}, {name1} {name2}.");


        }
    }
}
