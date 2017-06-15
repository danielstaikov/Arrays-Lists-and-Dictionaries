using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersices_from_lecture_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
           // string input = Console.ReadLine();
           // string[] inputTokens = input.Split(' '); //използва празно място за разделител и разделя стринга на масив от стрингове.
            string[] inputTokens =Console.ReadLine().Split(' '); // това е по-хитрия начин.
            int[] arrNumbers = new int[inputTokens.Length];

            for (int i = 0; i < arrNumbers.Length ; i++) //присвоявам стойности на инт. масив като парсвам стринговете
            {
                arrNumbers[i] = int.Parse(inputTokens[i]);
            }
            // някакви операции с масива

            for (int i = 0; i < arrNumbers.Length; i++) // печатам масива
            {
                Console.Write(arrNumbers[i]+" ");
            }
            Console.WriteLine();

        }
    }
}
