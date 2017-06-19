using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNum= Console.ReadLine().Split(' ');
            string[] names= Console.ReadLine().Split(' ');
            bool jobsToWork = true;
            while (jobsToWork)
            {
                string input = Console.ReadLine();
                if (input=="done")
                {
                    jobsToWork = false;
                }
                else
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i]== input)
                        {
                            Console.WriteLine($"{names[i]} -> {phoneNum[i]}");
                        }
                    }
                }

            }
        }
    }
}
