using System;

namespace InCLassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputInfo = Console.ReadLine();

            Console.WriteLine(InputInfoToUpperCase(inputInfo));
        }

        private static string InputInfoToUpperCase(string inputInfo)
        {
            return inputInfo.ToUpper();
        }
    }
}
