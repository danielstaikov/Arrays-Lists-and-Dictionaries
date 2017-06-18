using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
 
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number>999)
                {
                    Console.WriteLine("too large"); 
                }
                else if (number >99)
                {
                    Console.WriteLine(GetWord(number));
                }
                else if (number>0)
                {
                    //miss
                }
                else if (number<-999)
                {
                    Console.WriteLine("too small");
                }
                else
                {
                    Console.Write("minus ");
                    Console.WriteLine(GetWord(Math.Abs(number)));          
                    
                }
            }
        }
        static string GetWord(int number)
        {
            string[] arrSingle = { "zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] arrTenth = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string result = null;
 
                int rem = number % 100;

                if (rem<19)
                {
                result = arrSingle[rem];
                }
                else
                {
                     if (rem % 10 ==0)
                     {
                         result = arrTenth[(rem - 1) / 10];
                     }
                     else
                     {
                         result = arrTenth[(rem / 10)-1] + " " + arrSingle[rem % 10];
                     }
                }
                number = number / 100;
            if (number==0)
            {
                return result;
            }
            else
            {
                result = arrSingle[number] + "-hundred and " + result;
            }   
                   
            return result;
        }
    }
}
