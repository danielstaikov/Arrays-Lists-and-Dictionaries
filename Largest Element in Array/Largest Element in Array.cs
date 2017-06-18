using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // array lenght
            int[] arrNumbers = new int[n]; // define the array
            int maxElement = int.MinValue;
            for (int i = 0; i < n; i++) // read numbers
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
                if (arrNumbers[i] >= maxElement)
                {
                    maxElement = arrNumbers[i];
                }
            }
            Console.WriteLine(maxElement);
        }
    }
}
