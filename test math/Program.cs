using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_math
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Console.ReadLine();
            char[] characters = result.ToCharArray();
            int[] arrNumbers = new int[characters.Length];
            int length = characters.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                arrNumbers[i] = int.Parse($"{characters[i]}");
                sum = sum + arrNumbers[i];

            }
        }
    }
}
