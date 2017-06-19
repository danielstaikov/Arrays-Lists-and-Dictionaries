using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_arr_tryParse
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine(); // препавя стринга и вади само цифрите във втория стринг
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                    result += input[i];
            }

            Console.WriteLine(result);
        }
    }
}
