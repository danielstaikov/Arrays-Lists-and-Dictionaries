using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNum = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            bool jobsToWork = true;
            while (jobsToWork)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "done")
                {
                    jobsToWork = false;
                }
                else
                {
                    if (input[0]== "call")
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i] == input[1])
                            {
                                Console.WriteLine($"calling {phoneNum[i]}...");
                                Console.WriteLine(CallEvent(phoneNum[i]));
                            }
                            else if (phoneNum[i] == input[1])

                            {
                                Console.WriteLine($"calling {names[i]}...");
                                Console.WriteLine(CallEvent(phoneNum[i]));
                            }
                        }
                    }
                    else // message
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i] == input[1])
                            {
                                Console.WriteLine($"sending sms to {phoneNum[i]}...");
                                Console.WriteLine(MessageEvent(phoneNum[i]));
                            }
                            else if (phoneNum[i] == input[1])

                            {
                                Console.WriteLine($"sending sms to {names[i]}...");
                                Console.WriteLine(MessageEvent(phoneNum[i]));
                            }
                        }
                    }

                }

            }
        }
        static string CallEvent(string input)
        {

            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                    result += input[i];
            }

            char[] characters = result.ToCharArray();
            int[] arrNumbers = new int[characters.Length];
            int length = characters.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                arrNumbers[i] = int.Parse($"{characters[i]}");
                sum = sum + arrNumbers[i];

            }

            TimeSpan duration = TimeSpan.FromSeconds(sum);

            if (sum%2 == 0)
            {
                result = $"call ended. duration: {duration.ToString(@"mm\:ss")}";
            }
            else
            {
                result = "no answer";
            }

            return result;
        }
        static string MessageEvent(string input)
        {
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                    result += input[i];
            }

            char[] characters = result.ToCharArray(); //ала бала за да прхвърля стринговия масив в интежерски. Онова дългото не сработи.
            int[] arrNumbers = new int[characters.Length];
            int length = characters.Length;
            int diff = 0;
            for (int i = 0; i < length; i++)
            {
                arrNumbers[i] = int.Parse($"{characters[i]}");
                diff = diff - arrNumbers[i];

            }

            if (diff % 2 == 0)
            {
                result = $"meet me there";
            }
            else
            {
                result = "busy";
            }

            return result;
        }
    }
}
