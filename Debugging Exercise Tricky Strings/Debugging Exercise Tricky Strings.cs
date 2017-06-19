using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_Exercise_Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string result = string.Empty;
            string currentString = Console.ReadLine();
            result = result + currentString;
            for (int i = 1; i < numberOfStrings; i++)
            {
                currentString = delimiter + Console.ReadLine();
                result = result + currentString;
            }
            Console.WriteLine(result);
        }
    }
}
