using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordInput = Console.ReadLine();

            bool passwordIsLegit = true;
            if (PasswordLenghtCheck(passwordInput) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                passwordIsLegit = false;
            }
            if (PasswordContentValidation(passwordInput) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                passwordIsLegit = false;
            }
            if (PasswordDigitsNumberValidation(passwordInput) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
                passwordIsLegit = false;
            }

            if (passwordIsLegit == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool PasswordLenghtCheck(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            return true;
        }

        static bool PasswordContentValidation(string password)
        {
            password = password.ToLower();
            bool isNumber = false;
            bool isLetter = false;

            for (int i = 0; i < password.Length; i++)
            {
                // ASCII       48 is number "0"        57 is number "9"             
                if ((int)password[i] >= 48 && (int)password[i] <= 57)
                {
                    isNumber = true;
                }
                // ASCII       97 is letter "a"       122 is letter "z"
                if ((int)password[i] >= 97 && (int)password[i] <= 122)
                {
                    isLetter = true;
                }
                if (isNumber == false && isLetter == false)
                {
                    return false;
                }
                isNumber = false;
                isLetter = false;
            }
            return true;
        }

        static bool PasswordDigitsNumberValidation(string password)
        {
            int digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if ((int)password[i] >= 48 && (int)password[i] <= 57)
                {
                    digitCounter++;
                }
            }
            if (digitCounter < 2)
            {
                return false;
            }

            return true;

        }
    }
}
