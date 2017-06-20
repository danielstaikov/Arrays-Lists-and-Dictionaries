using System;

using System.Linq;

namespace Resizable_Array_2._0
{
    class Program
    {
        static int[] elements;
        static int elementsLenght;

        static void Main(string[] args)
        {
            string[] inputToken = Console.ReadLine().Split(' ');
            int[] elements = new int[4];
            elementsLenght = 0;

            while (inputToken[0] != "end")
            {
                string command = inputToken[0];

                switch (command)
                {
                    case "push":
                        elements[elementsLenght] = int.Parse(inputToken[1]);
                        elementsLenght++;

                        if (elementsLenght >= elements.Length)
                        {
                            GrowArrey();
                        }
                        break;
                    case "pop":
                        //elements[elementsLenght] = 0;
                        elementsLenght--;
                        break;
                    case "removeAt":
                        int index = int.Parse(inputToken[1]);
                        ShiftArrey(index);
                        elementsLenght--;
                        break;
                    case "clear":
                        elementsLenght = 0;
                        break;
                }
                inputToken = Console.ReadLine().Split(' ');
            }
            PrintArrey();
        }
        static void PrintArrey()
        {
            for (int i = 0; i < elementsLenght; i++)
            {
                Console.Write(elements[i]+" ");
            }
            Console.WriteLine();
        }
        static void GrowArrey()
        {
            int[] newArr = new int[elementsLenght * 2];

            for (int i = 0; i < elementsLenght; i++)
            {
                newArr[i] = elements[i];
            }

            elements = newArr;
        }
        static void ShiftArrey(int index)
        {
            for (int i = index+1; i < elementsLenght; i++)
            {
                elements[i - 1] = elements[i];
            }
        }
    }
}
