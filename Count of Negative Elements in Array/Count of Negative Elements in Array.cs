using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            int[] arrNumbers = new int[n]; 
            int negativeElements = 0;
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
                if (arrNumbers[i] < 0)
                {
                    negativeElements++;
                }
            }

            Console.WriteLine(negativeElements);
        }
    }
}
