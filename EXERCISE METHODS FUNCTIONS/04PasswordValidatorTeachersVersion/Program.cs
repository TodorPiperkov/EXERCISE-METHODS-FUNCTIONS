using System;

namespace _04PasswordValidatorTeachersVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();
            bool isBetweenSixAndTenChars = StringLengthChecher(inputPassword);
            bool isOnlyLettersAndDigits = StringCharChecker(inputPassword);
            bool haveAtleastTwoDigits = DigitCountChecher(inputPassword);
            WrongPasswordPrint(isBetweenSixAndTenChars, isOnlyLettersAndDigits, haveAtleastTwoDigits);
        }

        private static void WrongPasswordPrint(bool isBetweenSixAndTenChars, bool isOnlyLettersAndDigits, bool haveAtleastTwoDigits)
        {
            if (!isBetweenSixAndTenChars)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            if (!isOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!haveAtleastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isOnlyLettersAndDigits && isBetweenSixAndTenChars && haveAtleastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool DigitCountChecher(string inputPassword)
        {
            int counter = 0;
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (char.IsDigit(inputPassword[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool StringCharChecker(string inputPassword)
        {
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (!char.IsLetterOrDigit(inputPassword[i]))
                {
                    return false;
                }
            }

            return true;

        }

        private static bool StringLengthChecher(string inputPassword)
        {
            if (inputPassword.Length > 5 && inputPassword.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
