using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_rem
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 15;
            while (number!=0)
            {
                int rem = number % 100;
                Console.WriteLine(rem);
                number = number / 100;
                Console.WriteLine(number);
            }
        }
    }
}
