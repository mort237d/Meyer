using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyer
{
    class Game
    {
        private Rules rules;
        private bool active = true;
        public Game()
        {
            rules = new Rules(this);
            Console.WriteLine("Something");
            while (active)
            {
                Console.Write(">>>");
                switch (Console.ReadKey().KeyChar.ToString())
                {
                    case "r":
                        rules.Role();
                        break;
                    case "e":
                        active = false;
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Press r to roll the dices, press e to exit or press c to clear");
                        break;
                }
            }
        }
    }
}
