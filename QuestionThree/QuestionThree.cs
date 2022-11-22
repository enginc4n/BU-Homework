using System;

namespace QuestionThree
{
    class QuestionThree
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int times = 6, diceOne = 0, diceTwo = 0;
            int[] frequency = new int[13];
            while (times > 0)
            {
                diceOne = RollDice();
                diceTwo = RollDice();
                frequency[diceOne + diceTwo] = frequency[diceOne + diceTwo] + 1;
                times--;
            }
            times = 0;

            foreach (var items in frequency)
            {
                times++;
                if (items == 0)
                {
                    continue;
                }
                Console.WriteLine(times + ": " + items);
            }
        }
        static int RollDice()
        {
            int rolledDice = random.Next(1, 7);
            return rolledDice;
        }
    }
}