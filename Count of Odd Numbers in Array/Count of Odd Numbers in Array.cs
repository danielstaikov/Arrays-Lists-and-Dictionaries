using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            int[] arrNumbers = new int[inputTokens.Length];
            int amountOfOddElements = 0;
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = int.Parse(inputTokens[i]);
                if (arrNumbers[i]%2 != 0)
                {
                    amountOfOddElements++;
                }
            }

            Console.WriteLine(amountOfOddElements);
        }
    }
}
