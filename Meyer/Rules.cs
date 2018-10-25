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
        public Rules()
        {
            Dice dice = new Dice();
            Random random = new Random();
            int number = numbers[random.Next(numbers.Length)];
            firstNumber = (number / 10) % 10;
            secondNumber = number % 10;

            Console.WriteLine(number);
            Console.WriteLine((number / 10) % 10);
            Console.WriteLine(number % 10);

            dice.PrintDice(firstNumber);
            dice.PrintDice(secondNumber);

            dice.BuildDice((number / 10) % 10, number % 10);

            dice.Animation();
        }
    }
}
