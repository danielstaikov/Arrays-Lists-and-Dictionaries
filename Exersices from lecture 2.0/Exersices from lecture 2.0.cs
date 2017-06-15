using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersices_from_lecture_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
            }
            // some operations

            for (int i = 0; i < n; i++)
            {
                Console.Write(arrNumbers[i]+" "); // печата масива на един ред
            }
            Console.WriteLine();
        }
    }
}
