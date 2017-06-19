using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Power_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int dayCount = 0;
            int season = input.Length;
            while (AreAnyPlantsSurvive(input))
            {
                for (int i = 0; i < season; i++)
                {
                    if (input[i]!=0)
                    {
                        if (dayCount % season != i)
                        {
                            input[i]--;
                        }
                    }
                }
                dayCount++;

                if (dayCount% season ==0)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] != 0)
                        {
                            input[i]++;
                        }
                    }
                }

            }
            int seasons = dayCount / 4;
            Console.WriteLine($"survived {dayCount} days ({seasons} seasons) ");
        }
        static bool AreAnyPlantsSurvive(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    return true; ;
                }
            }

            return false;
        }
    }
}
