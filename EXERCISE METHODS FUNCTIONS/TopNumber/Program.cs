using System;
using System.Collections.Generic;
using System.Linq;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= maxNum; i++)
            {

                int sum = 0;
                bool isOdd = false;
                int currentNum = i;
                while (currentNum > 0)
                {
                    if (currentNum == 0) break;
                    int midNum = currentNum % 10;
                    sum += midNum;
                    if (!(midNum % 2 == 0)) isOdd = true;   
                    currentNum = currentNum / 10;  
                }
                if (sum % 8 == 0 && isOdd == true)
                {
                    Console.WriteLine(i);
                }
                
            }
            
        }
    }
}
