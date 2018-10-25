using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyer
{
    class Dice
    {
        private string spacer = "   ";
        string[,] diceArrayStrings = new string[6,5];
        private string[] diceArray1 = new[] { "+-------+",
                                              "|       |",
                                              "|   0   |",
                                              "|       |",
                                              "+-------+" };

        private string[] diceArray2 = new[] { "+-------+",
                                              "|     0 |",
                                              "|       |",
                                              "| 0     |",
                                              "+-------+" };

        private string[] diceArray3 = new[] { "+-------+",
                                              "|     0 |",
                                              "|   0   |",
                                              "| 0     |",
                                              "+-------+" };

        private string[] diceArray4 = new[] { "+-------+",
                                              "| 0   0 |",
                                              "|       |",
                                              "| 0   0 |",
                                              "+-------+" };

        private string[] diceArray5 = new[] { "+-------+",
                                              "| 0   0 |",
                                              "|   0   |",
                                              "| 0   0 |",
                                              "+-------+" };

        private string[] diceArray6 = new[] { "+-------+",
                                              "| 0   0 |",
                                              "| 0   0 |",
                                              "| 0   0 |",
                                              "+-------+" };
        public Dice()
        {
            for (int j = 0; j < 5; j++)
            {
                diceArrayStrings[0, j] = diceArray1[j];
                diceArrayStrings[1, j] = diceArray2[j];
                diceArrayStrings[2, j] = diceArray3[j];
                diceArrayStrings[3, j] = diceArray4[j];
                diceArrayStrings[4, j] = diceArray5[j];
                diceArrayStrings[5, j] = diceArray6[j];
            }
        }

        public void BuildDice(int firstNumber, int secondNumber)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(diceArrayStrings[firstNumber-1, i]);
                Console.Write(spacer);
                Console.Write(diceArrayStrings[secondNumber-1, i]);
                Console.WriteLine();
            }

            if (firstNumber == 1 && secondNumber == 2) Console.WriteLine("+------(Meyer)------+");
            else if (firstNumber == 1 && secondNumber == 3) Console.WriteLine("+---(Lille Meyer)---+");
            else if (firstNumber == 3 && secondNumber == 2) Console.WriteLine("+---(Fælles skål)---+");
            else if (firstNumber == 1 && secondNumber == 1) Console.WriteLine("+------(Par 1)------+");
            else if (firstNumber == 2 && secondNumber == 2) Console.WriteLine("+------(Par 2)------+");
            else if (firstNumber == 3 && secondNumber == 3) Console.WriteLine("+------(Par 3)------+");
            else if (firstNumber == 4 && secondNumber == 4) Console.WriteLine("+------(Par 4)------+");
            else if (firstNumber == 5 && secondNumber == 5) Console.WriteLine("+------(Par 5)------+");
            else if (firstNumber == 6 && secondNumber == 6) Console.WriteLine("+------(Par 6)------+");
            else Console.WriteLine("+-------(" + firstNumber + " " + secondNumber + ")-------+");

        }
        public void PrintDice(int eye)
        {
            if (eye == 1)
            {
                Console.WriteLine("+-------+" +
                                  "\n|       |" +
                                  "\n|   0   |" +
                                  "\n|       |" +
                                  "\n+-------+");
            }
            else if (eye == 2)
            {
                Console.WriteLine("+-------+" +
                                  "\n|     0 |" +
                                  "\n|       |" +
                                  "\n| 0     |" +
                                  "\n+-------+");
            }
            else if (eye == 3)
            {
                Console.WriteLine("+-------+" +
                                  "\n|     0 |" +
                                  "\n|   0   |" +
                                  "\n| 0     |" +
                                  "\n+-------+");
            }
            else if (eye == 4)
            {
                Console.WriteLine("+-------+" +
                                  "\n| 0   0 |" +
                                  "\n|       |" +
                                  "\n| 0   0 |" +
                                  "\n+-------+");
            }
            else if (eye == 5)
            {
                Console.WriteLine("+-------+" +
                                  "\n| 0   0 |" +
                                  "\n|   0   |" +
                                  "\n| 0   0 |" +
                                  "\n+-------+");
            }
            else if (eye == 6)
            {
                Console.WriteLine("+-------+" +
                                  "\n| 0   0 |" +
                                  "\n| 0   0 |" +
                                  "\n| 0   0 |" +
                                  "\n+-------+");
            }
            else
            {
                Console.WriteLine("         " +
                                  "\n         " +
                                  "\n         " +
                                  "\n         " +
                                  "\n         ");
            }
        }

        public void Animation()
        {
            Console.WriteLine(  "      +-----+" +
                              "\n     /       \\" +
                              "\n    /         \\" +
                              "\n   /           \\" +
                              "\n  /             \\" +
                              "\n /               \\" +
                              "\n/_________________\\");
        }
    }
}
