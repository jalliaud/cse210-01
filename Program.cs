using System;

namespace program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your Grade?: ");
            string answer = Console.ReadLine();
            int percent = int.Parse(answer);

            string grade = "";

            if (percent >= 90)
            {
                grade = "A";
            }
            else if (percent >= 80)
            {
                grade = "B";
            }
            else if (percent >= 70)
            {
                grade = "C";
            }
            else if (percent >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine($"Your grade is {grade}");
            
            if (percent < 70)
            {
                Console.WriteLine("You failed");
            }
            else
            {
                Console.WriteLine("You passed");
            }
        }
    }
}