﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GetHello(name);
        }
        static void GetHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
