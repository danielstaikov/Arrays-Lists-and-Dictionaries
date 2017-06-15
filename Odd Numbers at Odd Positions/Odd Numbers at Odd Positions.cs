using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            int[] arrNumbers = new int[inputTokens.Length];
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = int.Parse(inputTokens[i]);
                if (i%2!=0)
                {
                    if (arrNumbers[i] % 2 != 0)
                    {
                        Console.WriteLine($"Index {i} -> {arrNumbers[i]}");
                    }
                }
            }
        }
    }
}
