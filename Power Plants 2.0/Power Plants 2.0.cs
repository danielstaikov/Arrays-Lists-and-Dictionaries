﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Plants_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

                int[] flowers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int daysCompleted = 0;
                int seasons = 0;

                while (flowers.Max() != 0)
                {
                    for (int days = 0; days < flowers.Length; days++)
                    {
                        for (int individual = 0; individual < flowers.Length; individual++)
                        {
                            if (days != individual && flowers[individual] > 0)
                            {
                                flowers[individual]--;
                            }
                        }

                        daysCompleted++;
                        if (flowers.Max() == 0) break;
                    }

                    if (flowers.Max() == 0) break;

                    for (int endOfSeason = 0; endOfSeason < flowers.Length; endOfSeason++)
                    {
                        if (flowers[endOfSeason] > 0)
                        {
                            flowers[endOfSeason]++;
                        }
                    }

                    seasons++;
                }

                Console.WriteLine($"survived {daysCompleted} days ({seasons} seasons)");
            }
        }
    }