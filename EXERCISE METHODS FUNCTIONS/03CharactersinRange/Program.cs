using System;
using System.Linq;

namespace _03CharactersinRange
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstChar = Console.ReadLine();
            string secondChar = Console.ReadLine();

            int numberOfThefirstChar = Int32.Parse(firstChar);
            int numberOfTheSecondChar = Int32.Parse(secondChar);

            for (int i = numberOfThefirstChar; i < numberOfTheSecondChar; i++)
            {
                Console.WriteLine(i.ToString());
            }

        }
    }
}
