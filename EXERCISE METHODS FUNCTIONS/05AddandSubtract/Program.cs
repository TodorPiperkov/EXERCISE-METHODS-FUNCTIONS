using System;

namespace _05AddandSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int sum = SumMethod(firstNum, secondNum);
            SumMethod(firstNum, secondNum);
            SubstractMethod(lastNum, sum);
            Console.WriteLine(SubstractMethod(lastNum, sum));
        }

        private static int SubstractMethod(int lastNum, int sum)
        {
            int answer = sum - lastNum;
            return answer;
        }

        private static int SumMethod(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }
    }
}
