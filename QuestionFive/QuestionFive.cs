using System;

namespace QuestionFive
{
    class QuestionFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            int counter = 2;
            if (givenNumber == 0 || givenNumber == 1)
            {
                flag = true;
            }
            while (counter < givenNumber && flag == false)
            {

                if (givenNumber % counter == 0)
                {
                    flag = true;
                }
                counter++;
            }

            if (flag == false)
            {
                Console.WriteLine("Your number is prime number");
            }
            else
            {
                Console.WriteLine("Your number is not prime number");

            }
        }
    }
}
