using System;
using System.Collections.Generic;
using System.Linq;

namespace _09PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = string.Empty;
            while (number != "END")
            {
                number = Console.ReadLine();
                PalindromeIntegers(number);
            }
            
        }

        private static void PalindromeIntegers(string number)
        {
                string firstList = string.Empty;
                string secondList = string.Empty;

                for (int i = 0; i < number.Length; i++)
                {
                    firstList += (number[i]);
                }
                for (int j = number.Length - 1; j >= 0; j--)
                {
                    secondList += (number[j]);
                }
            if (number == null)
            {
                return;
            }
                if (firstList == secondList)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
        }
    }
}
