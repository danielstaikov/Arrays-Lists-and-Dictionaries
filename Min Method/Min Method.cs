using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int min = GetMin(numberOne, numberTwo);
            int numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMin(min, numberThree)); 
        }
   static int GetMin(int a, int b)
        {
            if (a<b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
