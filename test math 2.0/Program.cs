using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_math_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit1 = number / 100;
            Console.WriteLine($"{digit1}");
            int digit2 = (number % 100) / 10;
            Console.WriteLine($"{digit2}");
            int digit3 = number % 10;
            Console.WriteLine($"{digit3}");
        }
    }
}
