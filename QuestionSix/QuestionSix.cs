using System;

namespace QuestionSix
{
    class QuestionSix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for repetition");
            int repetition = Convert.ToInt32(Console.ReadLine());
            string[] givenArray = new string[repetition];
            for (int i = 0; i < givenArray.Length; i++)
            {
                Console.WriteLine("Enter your string");
                givenArray[i] = Console.ReadLine();
            }
            Console.WriteLine("Your reversed array: ");
            for (int i = givenArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(givenArray[i]);
            }
        }
    }
}
