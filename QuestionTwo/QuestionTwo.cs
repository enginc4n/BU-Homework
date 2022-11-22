using System;

namespace QuestionTwo
{
    class QuestionTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int givenNumber = Convert.ToInt32(Console.ReadLine());


            int[] givenArray = new int[givenNumber];
            int[] evenArray = new int[givenNumber];

            for (int i = 0; i < givenArray.Length; i++)
            {
                Console.WriteLine("Enter your number.");
                givenArray[i] = Convert.ToInt32(Console.ReadLine());
                if (givenArray[i] % 2 == 0)
                {
                    evenArray[i] = givenArray[i];
                }
            }
            Console.WriteLine("Your even numbers:");

            foreach (var numbers in evenArray)
            {
                if (numbers == 0)
                {
                    continue;
                }

                Console.Write(numbers + " ");
            }
        }
    }
}
