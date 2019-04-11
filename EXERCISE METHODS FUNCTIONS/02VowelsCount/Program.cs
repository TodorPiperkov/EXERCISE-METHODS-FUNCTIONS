using System;
using System.Linq;

namespace _02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            VowelsCount();
        }

        private static void VowelsCount()
        {
            int total = 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            string theVowels = Console.ReadLine().ToLower();

            total = theVowels.Count(x => vowels.Contains(x));
            Console.WriteLine(total);
        }
    }
}
