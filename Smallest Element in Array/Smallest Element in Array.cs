using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' '); 
            int[] arrNumbers = new int[inputTokens.Length];
            int minElement = int.MaxValue;
            for (int i = 0; i < arrNumbers.Length; i++) 
            {
                arrNumbers[i] = int.Parse(inputTokens[i]);
                if (arrNumbers[i]<= minElement)
                {
                    minElement = arrNumbers[i];
                }
            }

            Console.WriteLine(minElement);
        }
    }
}
