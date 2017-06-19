using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            int lenght = inputTokens.Length - 1;
            int i = 0;
            int count = 0;
            while (count != 2)
            {
                
                if (inputTokens[lenght - i] == inputTokens[(lenght - 1) - i])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (i< lenght)
                {
                    i++;
                }
                else
                {
                    break;
                }
                

            }
            Console.WriteLine(inputTokens[inputTokens.Length - i]+" " +inputTokens[inputTokens.Length - i]+ " " + inputTokens[inputTokens.Length - i]);
           
        }
    }
}
