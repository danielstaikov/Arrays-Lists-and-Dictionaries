using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            int[] arrNumbers = new int[inputTokens.Length];
            long altitude = arrNumbers[0] = int.Parse(inputTokens[0]);

            for (int i = 1; i < (inputTokens.Length - 1); i = i + 2)
            {
                string oper = null;
                switch (inputTokens[i])
                {
                    case "up":
                        oper = "+";
                        break;
                    case "down":
                        oper = "-";
                        break;
                }

                altitude = altitude + (long.Parse(oper + inputTokens[i + 1]));

            }
            if (altitude > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }

        }
    }
}

