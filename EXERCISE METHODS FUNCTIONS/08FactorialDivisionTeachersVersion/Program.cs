using System;

namespace _08FactorialDivisionTeachersVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());

            long firstNumFac = GetFactorial(firstNum);
            long secNumFac = GetFactorial(secondNum);
            double result = (double)firstNumFac / secNumFac;
            Console.WriteLine($"{result:F2}");
        }

        private static long GetFactorial(long number)
        {
            long factorial = 1;
            for (long i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
