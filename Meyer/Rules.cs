using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyer
{
    class Rules
    {
        int[] numbers = new int[] {32, 41, 42, 43, 51, 52, 53, 54, 61, 62, 63, 64, 65, 11, 22, 33, 44, 55, 66, 13, 12};
        private int firstNumber;
        private int secondNumber;
        private Dice dice;
        private Random random;
        public Rules(Game game)
        {
            dice = new Dice();
            random = new Random();
        }

        public void Role()
        {
            int number = numbers[random.Next(numbers.Length)];
            firstNumber = (number / 10) % 10;
            secondNumber = number % 10;

            Console.Clear();
            dice.Animation();
            dice.BuildDice((number / 10) % 10, number % 10);
        }
    }
}
