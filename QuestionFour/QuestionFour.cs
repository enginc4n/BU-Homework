using System;

namespace QuestionFour
{
    class QuestionFour
    {
        static void Main(string[] args)
        {
            int givenNumbers, divider;

            Console.WriteLine("Enter the number that you want to enter");
            givenNumbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your divider");
            divider = Convert.ToInt32(Console.ReadLine());

            int[] givenArray = new int[givenNumbers];

            for (int i = 0; i < givenArray.Length; i++)
            {
                Console.WriteLine("Enter your number");
                givenArray[i] = Convert.ToInt32(Console.ReadLine());
                if (givenArray[i] % divider == 0)
                {
                    Console.WriteLine("Your number can divisible by " + divider);
                }
            }
        }
    }
}
