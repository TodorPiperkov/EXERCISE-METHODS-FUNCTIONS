using System;

namespace _07NxNMatrixTeachersVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintMatrixWIthGivenNumber(number);
        }

        private static void PrintMatrixWIthGivenNumber(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int cow = 1; cow <= number; cow++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
