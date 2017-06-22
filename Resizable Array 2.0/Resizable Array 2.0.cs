using System;

using System.Linq;


    class Program
    {
        static int[] elements;
        static int elementsLength;//elementsLength

        static void Main(string[] args)
        {
            string[] inputToken = Console.ReadLine().Split(' ');
            int[] elements = new int[4];
            elementsLength = 0;

            while (inputToken[0] != "end")
            {
                string command = inputToken[0];

                switch (command)
                {
                    case "push":
                        elements[elementsLength] = int.Parse(inputToken[1]);
                        elementsLength++;

                        if (elementsLength >= elements.Length)
                        {
                            GrowArray();
                        }
                        break;
                    case "pop":
                        elements[elementsLength] = 0;
                        elementsLength--;
                        break;
                    case "removeAt":
                        int index = int.Parse(inputToken[1]);
                        ShiftArray(index);
                        elementsLength--;
                        break;
                    case "clear":
                        elementsLength = 0;
                        break;
                    default:
                        break;
                }
                inputToken = Console.ReadLine().Split(' ');
            }
            PrintArray();
        }
        static void PrintArray()
        {
            for (int cnt = 0; cnt < elementsLength; cnt++)
            {
                Console.Write(elements[cnt] + " ");
            }

            Console.WriteLine();
        }
        static void GrowArray()
        {
            int[] newArray = new int[elementsLength * 2];

            for (int cnt = 0; cnt < elementsLength; cnt++)
            {
                newArray[cnt] = elements[cnt];
            }

            elements = newArray;
        }
        static void ShiftArray(int index)
        {
            for (int cnt = index + 1; cnt < elementsLength; cnt++)
            {
                elements[cnt - 1] = elements[cnt];
            }
        }
    }
