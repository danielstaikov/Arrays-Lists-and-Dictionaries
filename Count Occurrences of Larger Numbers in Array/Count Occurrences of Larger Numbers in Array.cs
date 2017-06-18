using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            double[] arrNumbers = new double[inputTokens.Length];
            double p = double.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = double.Parse(inputTokens[i]);
                if (p <= arrNumbers[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
