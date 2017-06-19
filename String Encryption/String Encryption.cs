using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[] arrChars = new char[number];

            for (int i = 0; i < number; i++)
            {
                arrChars[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number; i++)
            {
                string result= string.Empty;
                result = result + Encrypt(arrChars[i]);

                Console.Write(result); 
            }
            Console.WriteLine();
        }
        static string Encrypt(char letter)
        {
            string result = null;
            int asscii = letter;
            int last = asscii % 10;
            asscii = asscii / 10;
            int first = 0;
            while (asscii > 0)
            {
                first = asscii % 10;
                asscii = asscii / 10;
            }
            asscii = letter;
            int firstCharacter = asscii + last;
            int lastCharacter = asscii - first;
            
            result = (char)firstCharacter + $"{first}" + $"{last}" + (char)lastCharacter;
            return result;
        }
    }
}
