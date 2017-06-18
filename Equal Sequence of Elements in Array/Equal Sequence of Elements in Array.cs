using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sequence_of_Elements_in_Array
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
            }

            for (int i = 0; i < arrNumbers.Length - 1; i++)
            {
                if (GetMax(arrNumbers[i], arrNumbers[i + 1]))
                {
                    Console.WriteLine("No");
                    break;
                }
                else if (GetMax(arrNumbers[i], arrNumbers[i + 1]) != true && i == arrNumbers.Length - 2)
                {
                    Console.WriteLine("Yes");
                }


            }

        }
        static bool GetMax(int a, int b)
        {
            if (a != b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
