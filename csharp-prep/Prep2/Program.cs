using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 2");

            Console.Write("What is your grade percentage? ");
            string grade = Console.ReadLine();
            Console.WriteLine($"Your grade for this course is, {grade}%.");
            float userGrade = float.Parse(grade);
            float aGrade = 90.00f;
            float bGrade = 80.00f;
            float cGrade = 70.00f;
            float dGrade = 60.00f;
            if (userGrade >= aGrade)
            {
                Console.WriteLine("You made an A grade.");
            }
            else if (userGrade >= bGrade)
            {
                Console.WriteLine("You made a B grade.");
            }
            else if (userGrade >= cGrade)
            {
                Console.WriteLine("You made a C grade.");
            }
            else if (userGrade >= dGrade)
            {
                Console.WriteLine("You made a D grade.");
            }
            else if (userGrade < dGrade)
            {
                Console.WriteLine("You made a F grade");
            }

            Console.WriteLine($"Remember, you must have at least a {cGrade}% to pass this course.");
            if (userGrade >= cGrade)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Sorry you did not pass this course. Study harder next year.");
            }
        }
    }
}
