using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Base_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(number, toBase));
        }
        public static string IntegerToBase(long number, int toBase)
        {
            string remainder = string.Empty;
            string result = string.Empty;

            while (number > 0)
            {
                remainder = (number % toBase).ToString();
                result = result.Insert(0, remainder);
                number /= toBase;
            }

            return result;
        }
    }
}
