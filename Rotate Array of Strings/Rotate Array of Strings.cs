using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] inputTokens = Console.ReadLine().Split(' ');
            string last = inputTokens[inputTokens.Length - 1];

            for (int i = inputTokens.Length - 2; i >= 0; i--)
            {
                inputTokens[i+1] = inputTokens[i];

            }
            inputTokens[0] = last;

            Console.WriteLine(string.Join(" ", inputTokens));
        }
    }
}
