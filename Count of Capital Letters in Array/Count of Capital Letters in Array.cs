using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] capitalString = Console.ReadLine().Split(' ').ToArray();
            int couter = 0;

            for (int i = 0; i < capitalString.Length; i++)
            {
                if (capitalString[i].Length == 1)
                {
                    int singleLetter = capitalString[i][0];
                    if (singleLetter >= 'A' && singleLetter <= 'Z')
                    {
                        couter++;
                    }
                }
            }
            Console.WriteLine(couter);
        }
    }
}
