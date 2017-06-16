using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int repeater = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(word,repeater));
        }
        static string RepeatString(string str, int count)
        {
            string repeatedString = null;

            for (int i = 0; i < count; i++)
            {
                repeatedString = repeatedString + str;
            }

            return repeatedString;
        }

    }
}
