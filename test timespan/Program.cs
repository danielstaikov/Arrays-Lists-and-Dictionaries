using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan interval =TimeSpan.FromSeconds (72);
            Console.WriteLine($"call ended. duration: {interval.ToString("mm':'ss")}");
        }
    }
}
