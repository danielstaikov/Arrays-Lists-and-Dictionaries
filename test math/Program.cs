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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool triangleValidityCondition1 = a + b > c;
            Console.WriteLine(triangleValidityCondition1);
            bool triangleValidityCondition2 = b + c > a;
            Console.WriteLine(triangleValidityCondition2);
            bool triangleValidityCondition3 = a + c > b;
            Console.WriteLine(triangleValidityCondition3);

            bool rightTriangleCondition1 = (a * a + b * b == c * c);
            Console.WriteLine(rightTriangleCondition1);
            bool rightTriangleCondition2 = (b * b + c * c == a * a);
            Console.WriteLine(rightTriangleCondition2);
            bool rightTriangleCondition3 = (a * a + c * c == b * b);
            Console.WriteLine(rightTriangleCondition3);
        }
    }
}
