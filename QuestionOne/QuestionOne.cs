using System;

namespace QuestionOne
{
    class QuestionOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string enteredString = Console.ReadLine();
            int numberOfSpace = 0, numberOfWords = 0;
            for (int i = 0; i < enteredString.Length; i++)
            {
                if (enteredString[i] == ' ')
                {
                    numberOfSpace += 1;
                }
            }
            if (enteredString.EndsWith(" ") == true)
            {
                numberOfSpace -= 1;
            }
            numberOfWords = numberOfSpace + 1;
            Console.WriteLine("Number of words = " + numberOfWords);
            Console.WriteLine("Number of letter = " + (enteredString.Length - numberOfSpace));
        }
    }
}
