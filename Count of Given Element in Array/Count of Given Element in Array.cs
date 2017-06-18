using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            int[] arrNumbers = new int[inputTokens.Length];
            int givenElement = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = int.Parse(inputTokens[i]);
                if (givenElement== arrNumbers[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
