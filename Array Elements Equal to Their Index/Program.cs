using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = arrNumbers.Length;

            for (int i = 0; i <= count-1; i++)
            {
                if (arrNumbers[i]== i)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
