using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
                sum = sum + arrNumbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
