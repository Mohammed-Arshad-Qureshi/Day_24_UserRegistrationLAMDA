using System;

namespace UserRegistrationLamda
{
    public class Program
    {
        static void Main(string[] args)
        {
            SetValidation validation = new SetValidation(); 
            Console.WriteLine("MSTesting");
            Console.WriteLine("\nWelcome to C# User's Information validation using Regular Expression");


            //User First name validation            
            Firstname:
            Console.WriteLine("\nNote : Your first name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.WriteLine("\n\nEnter your first name : ");
            string fName = Console.ReadLine(); 
            string checkFirstName = validation.FirstNameValidation(fName);
            if (checkFirstName != "Input is valid")
                goto Firstname;

            // User Last name validation
            Lastname:
            Console.WriteLine("\nNote : Your Last name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.WriteLine("\n\nEnter your last name : ");
            string lName = Console.ReadLine();
            string checkLastName = validation.LastNameValidation(lName);
            if (checkLastName == "Input is valid")
                goto Lastname;

            // User Email Validation
            Email:
            Console.WriteLine("\n\nEnter your email name : ");
            string email = Console.ReadLine(); 
            string checkEmail = validation.EmailValidation(email); 
            if (checkEmail != "Input is valid")
                goto Email;

            //user Mobile Number validation
            MobileNumber:
            Console.WriteLine("\n\nEnter your Mobile Number : ");
            string mNo = Console.ReadLine();
            string checkMobileNo = validation.MobileNumberValidation(mNo); 
            if (checkMobileNo != "Input is valid")
                goto MobileNumber;

            //user Password validation
            Password:
            Console.WriteLine("\nPassword Rules");
            Console.WriteLine("Rule 1 : Minimum 8 Character");
            Console.WriteLine("Rule 2 : Atleast one Uppercase letter");
            Console.WriteLine("\n\nEnter your Password : ");
            string password = Console.ReadLine();
            string checkPassword = validation.PasswordRule1Validation(password); 
            if (checkPassword != "Input is valid")
                goto Password;

            //user Password validation
            Password2:
            Console.WriteLine("\nPassword Rules");
            Console.WriteLine("Rule 1 : Minimum 8 Character");
            Console.WriteLine("Rule 2 : Atleast one Uppercase letter");
            Console.WriteLine("\n\nEnter your Password : ");
            string password2 = Console.ReadLine(); 
            string checkPassword2 = validation.PasswordRule2Validation(password2);
            if (checkPassword2 != "Input is valid")
                goto Password2;

            //user Password validation
            Password3:
            Console.WriteLine("\nPassword Rules");
            Console.WriteLine("Rule 1 : Minimum 8 Character");
            Console.WriteLine("Rule 2 : Atleast one Uppercase letter");
            Console.WriteLine("\n\nEnter your Password : ");
            string password3 = Console.ReadLine(); 
            string checkPassword3 = validation.PasswordRule3Validation(password3);
            if (checkPassword3 != "Input is valid")
                goto Password3;

            //user Password validation
            Password4:
            Console.WriteLine("\nPassword Rules");
            Console.WriteLine("Rule 1 : Minimum 8 Character");
            Console.WriteLine("Rule 2 : Atleast one Uppercase letter");
            Console.WriteLine("\n\nEnter your Password : ");
            string password4 = Console.ReadLine();
            string checkPassword4 = validation.PasswordRule4Validation(password4); 
            if (checkPassword4 != "Input is valid")
                goto Password4;

        }
    }
}
