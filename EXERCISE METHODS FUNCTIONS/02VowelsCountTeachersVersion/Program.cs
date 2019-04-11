using System;

namespace _02VowelsCountTeachersVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Console.WriteLine(VowelsCount(input)); ;
        }

        private static int VowelsCount(string input)
        {
        int vowelsCount = 0;
            string inputToLower = input.ToLower();
            for (int i = 0; i<input.Length; i++)
			{
                if (inputToLower[i] == 'a' ||
                    inputToLower[i] == 'e' ||
                    inputToLower[i] == 'i' ||
                    inputToLower[i] == 'o' ||
                    inputToLower[i] == 'u')
                {
                    vowelsCount++;
                }
			}
            return vowelsCount;
        }
    }
}
