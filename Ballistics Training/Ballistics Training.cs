using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targetCoord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split(' ');
            int coordX = 0;
            int coordY = 0;
            for (int i = 0; i < commands.Length ; i = i + 2)
            {
                string oper = null;
                switch (commands[i])
                {
                    case "right":
                    case "up":
                        oper = "+";
                        break;
                    case "down":
                    case "left":
                        oper = "-";
                        break;
                }

                if ((commands[i] == "right"|| commands[i] == "left") &&( int.Parse(commands[i+1]) >= 0))
                {
                    coordX = coordX + (int.Parse(oper + commands[i + 1]));
                }
                else if ((commands[i] == "left") && (int.Parse(commands[i + 1]) < 0))
                {
                    int a = int.Parse(commands[i + 1]) * (-1);
                    coordX = coordX + a;
                }
                else if (((commands[i] == "up" || commands[i] == "down") && (int.Parse(commands[i + 1]) >= 0)))
                {
                    coordY = coordY + (int.Parse(oper + commands[i + 1]));
                }
                else
                {
                    int a = int.Parse(commands[i + 1]) * (-1);
                    coordY = coordY + a;
                }


            }
            Console.WriteLine($"firing at [{targetCoord[0]}, {targetCoord[1]}]");
            if (coordX == targetCoord[0] && coordY == targetCoord[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
