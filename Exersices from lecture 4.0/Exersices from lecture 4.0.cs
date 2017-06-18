using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersices_from_lecture_4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targetCoord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commands =Console.ReadLine().Split(' '); 
            int[] commandNumbers = new int[commands.Length];

            for (int i = 0; i < commandNumbers.Length ; i++) 
            {
                commandNumbers[i] = int.Parse(commands[i]);
            }
            // някакви операции с масива

           // foreach (var number in arrNumbers)// във foreach елементите са read only
           // {
           //     Console.Write(number+" ");
           // }
           // Console.WriteLine();

            Console.WriteLine(string.Join(", ", commandNumbers)); //също печата стринга
        }
    }
}
