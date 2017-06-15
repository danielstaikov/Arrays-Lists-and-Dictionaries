using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' '); 
            double[] arrNumbers = new double[inputTokens.Length];
            double multiply = double.Parse(Console.ReadLine());

            for (int i = 0; i < arrNumbers.Length; i++) 
            {
                arrNumbers[i] = double.Parse(inputTokens[i]);
                arrNumbers[i] = arrNumbers[i] * multiply;
            }
            
            for (int i = 0; i < arrNumbers.Length; i++) // печатам масива
            {
                Console.Write(arrNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
