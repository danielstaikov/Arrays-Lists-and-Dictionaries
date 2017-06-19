using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            bool isSymArr = true;

            for (int i = 0; i < inputTokens.Length/2; i++)
            {
                if (inputTokens[i] == inputTokens[inputTokens.Length - i -1])
                {
                    isSymArr = true;
                }
                else
                {
                    isSymArr = false;
                    break;
                }
            }
            Console.WriteLine("{0}", isSymArr?"Yes":"No");

        }
    }
}
