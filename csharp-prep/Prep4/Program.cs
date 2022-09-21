using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int userNumber = -1;

            while (userNumber != 0)
            {
                Console.Write("Enter a number (0 to quit): ");

                string userResponse = Console.ReadLine();
                userNumber = int.Parse(userResponse);

                numbers.Add(userNumber);
                if(userNumber == 0){
                break;
                }
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            float average = sum/ numbers.Count;
            Console.WriteLine($"The average is: {average}");

            
        }
    
    }
}
