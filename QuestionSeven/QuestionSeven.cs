using System;

namespace QuestionSeven
{
    class QuestionSeven
    {
        static void Main(string[] args)
        {
            int number, divider, remainder;

            Console.WriteLine("Enter your number");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your divider");
            divider = Convert.ToInt32(Console.ReadLine());

            if (divider > number)
            {
                remainder = number;
            }
            else if (divider == number)
            {
                remainder = 0;
            }
            else
            {
                remainder = number % divider;
            }
            Console.WriteLine($"Your remainder is {remainder}");
        }
    }
}
