
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTokens = Console.ReadLine();
            int[] arrInt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] arrChar = inputTokens.ToCharArray();
            string result = string.Empty;
            int number = 0;
            for (int i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i]%2==0)
                {
                    number = (int)arrChar[i] - arrInt[i];
                }
                else
                {
                    number = (int)arrChar[i] + arrInt[i];
                }
                
                result = result + (char)number;

            }

            Console.WriteLine(result);
        }
    }
}
