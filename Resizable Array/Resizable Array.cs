using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resizable_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumber = new int[4];
            bool isNotCode = true;
            int count = 0;
            int additional = 0;
            while (isNotCode)
            {
                string inputToken = Console.ReadLine();
                if (inputToken == "end")
                {
                    isNotCode = false;
                }
                else
                {
                    switch ($"{inputToken[0]}")
                    {
                        case "push":
                            additional = int.Parse($"inputToken[1]")
                            arrNumber = GetPush(arrNumber, additional);

                            arrNumber[4] = int.Parse($"inputToken[1]");
                            break;
                        case "pop":

                            break;
                        case "removeAt":

                            break;
                        case "clear":

                            break;


                    }



                }
            }

        }
        static Array GetPush(int[] number, int additional)
        {
            int[] arrResult = new int[4];


            return arrResult;
        }
    }
}
