using System;

namespace UserRegistrationLamda
{
    public class Program
    {
        static void Main(string[] args)
        {
            SetValidation validation = new SetValidation();
            Console.WriteLine("\nWelcome to C# User's Information validation using Regular Expression");
            //User First name validation            
             Firstname:
            Console.WriteLine("\nNote : Your first name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.Write("\n\nEnter your first name :   ");
            string fName = Console.ReadLine();
            bool checkFirstName = validation.FirstNameValidation(fName);
            if (!checkFirstName)//If not valid then ask user to enter first name again
                goto Firstname;

            // User Last name validation
            Lastname:
            Console.WriteLine("\nNote : Your Last name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.WriteLine("\n\nEnter your last name : ");
            string lName = Console.ReadLine();
            bool checkLastName = validation.LastNameValidation(lName);
            if (!checkLastName)
                goto Lastname;


            // User Email Validation
            Email:
            Console.WriteLine("\n\nEnter your email name : ");
            string email = Console.ReadLine();
            bool checkEmail = validation.EmailValidation(email);
            if (!checkEmail)
                goto Email;

            //user Mobile Number validation
            MobileNumber:
            Console.WriteLine("\n\nEnter your Mobile Number : ");
            string mNo = Console.ReadLine();
            bool checkMobileNo = validation.MobileNumberValidation(mNo);
            if (!checkMobileNo)
                goto MobileNumber;
        }
    }
}
