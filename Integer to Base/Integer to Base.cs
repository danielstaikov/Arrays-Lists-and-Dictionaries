﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(number, toBase));
        }
        static string IntegerToBase(long number, int toBase)
        {
            string result = string.Empty;
            while (number > 0)
            {
                long rem = number % toBase;
                result = $"{rem}" + result;
                number = number / toBase;
            }
            return result;
        }

    }
}
