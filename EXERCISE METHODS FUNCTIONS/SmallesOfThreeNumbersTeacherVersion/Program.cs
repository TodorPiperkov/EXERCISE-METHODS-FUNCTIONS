using System;

namespace SmallesOfThreeNumbersTeacherVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(NumberComparison(firstNumber, secondNumber, lastNumber));
        }

        static int NumberComparison(int firstNumber, int secondNumbet, int lastNumber)
        {
            if (firstNumber < secondNumbet && firstNumber < lastNumber)
            {
                return firstNumber;
            }
            else if (secondNumbet < firstNumber && secondNumbet < lastNumber)
            {
                return secondNumbet;
            }
            else
            {
                return lastNumber;
            }
        }
    }
}
