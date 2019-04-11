using System;

namespace _01SmallestofThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallesOfThreeNumbers();
        }

        private static void SmallesOfThreeNumbers()
        {
            int smallestNum = int.MaxValue;

            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < smallestNum)
                {
                    smallestNum = num;
                }
            }
            Console.WriteLine(smallestNum);
        }
    }
}
