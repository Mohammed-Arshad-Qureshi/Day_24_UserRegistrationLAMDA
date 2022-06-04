using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationLamda
{
    class LamdaExpression
    {
        //Validating Userinput
        public void Validate()
        {
            string[] RegexPattern = new string[6];

            //For First name
            RegexPattern[0] = "^[A-Z][A-Za-z]{2,}$";

            //For Last Name
            RegexPattern[1] = "^[A-Z][A-Za-z]{2,}$";

            //For Email id
            RegexPattern[2] = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

            //For Phone Number
            RegexPattern[3] = "^[1-9]{2,}[ ][0-9]{10}$";

            //For Password
            RegexPattern[4] = "^[A-Za-z0-9]*[!@#$%^$*]{1}([a-zA-Z0-9])*$";

            string[] UserInput = new string[6];

            //Geting User in
            Console.WriteLine("Enter First Name:");
            UserInput[0] = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            UserInput[1] = Console.ReadLine();

            Console.WriteLine("Enter Email Id:");
            UserInput[2] = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            UserInput[3] = Console.ReadLine();

            Console.WriteLine("Enter passward:");
            UserInput[4] = Console.ReadLine();

            Console.WriteLine("\nResults are: ");
            //Lambda Expression
            for (int i = 0; i < 6; i++)
            {
                try
                {
                    Func<string, bool> nameValidater = UserInput => Regex.IsMatch(UserInput, RegexPattern[i]);
                    bool result = nameValidater(UserInput[i]);
                    Console.WriteLine(($"{i + 1} {UserInput[i]} : {result}"));

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               

            }

        }
    }
}
