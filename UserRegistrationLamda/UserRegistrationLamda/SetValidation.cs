using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationLamda
{
    public class SetValidation
    {
        public bool FirstNameValidation(string fName)
        {
            // Regex for first name validation
            string pattern = "^[A-Z][a-z]{2,}$";
            if (Regex.IsMatch(fName, pattern))
            {
                Console.WriteLine("\nYour first name {0} is valid", fName);
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour first name \"{fName}\" is not valid");
                Console.WriteLine("\nPlease follow naming convention of first name");
                return false;
            }
        }

        public bool LastNameValidation(string lName)
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Regex for last name validation
            if (Regex.IsMatch(lName, pattern))
            {
                Console.WriteLine($"\nYour last name \"{lName}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour last name \"{lName}\" is not valid");
                Console.WriteLine("\nPlease follow naming convention of last name");
                return false;
            }
        }
    }
}
