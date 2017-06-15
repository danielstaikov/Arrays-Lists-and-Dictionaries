using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersices_from_lecture_4._0
{
    class Program
    {
        static void Main(string[] args)
        {
 
            string[] inputTokens =Console.ReadLine().Split(' '); 
            int[] arrNumbers = new int[inputTokens.Length];

            for (int i = 0; i < arrNumbers.Length ; i++) 
            {
                arrNumbers[i] = int.Parse(inputTokens[i]);
            }
            // някакви операции с масива
            foreach (var number in arrNumbers)// във foreach елементите са read only
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();
        }
    }
}
