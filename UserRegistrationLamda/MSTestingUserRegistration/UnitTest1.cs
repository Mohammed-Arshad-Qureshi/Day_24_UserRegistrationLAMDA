using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationLamda;

namespace MSTestingUserRegistration
{
    [TestClass]
    public class UnitTest1
    {

        SetValidation validation;
        [TestInitialize]
        public void SetUp()
        {
            validation = new SetValidation();
        }
        [TestClass]
        public class UserValidation
        {
            [TestMethod]
            //Checking for multiple first name
            [DataRow("Arshad", true)]
            [DataRow("Ar", false)]
            [DataRow("arshad", false)]
            [DataRow("ar", false)]
            [DataRow("Ars", true)]
            public void GivenFirstNameValidation(string firstName, bool expected) // Testing for Firstname Validation
            {
                //Arrange
                SetValidation validation = new SetValidation();
                //Act
                bool actual = validation.FirstNameValidation(firstName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        //Checking for multiple last name
        [DataRow("Rakhade", true)]
        [DataRow("ra", false)]
        [DataRow("rakhade", false)]
        [DataRow("Ra", false)]
        [DataRow("Rak", true)]
        public void GivenLastNameValidation(string lastName, bool expected) // Testing for Lastname Validation
        {
            //Arrange
            SetValidation validation = new SetValidation();
            //Act
            bool actual = validation.FirstNameValidation(lastName);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        //Checking for multiple email samples
        [DataRow("abc123@.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc+100@gmail.com", true)]
        [DataRow("abc@1.com", true)]
        public void GivenEmailValidation(string email, bool expected) // Testing for Email Validation
        {
            //Act
            bool actual = validation.EmailValidation(email);
            //Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        //Checking for multiple mobile number samples
        [DataRow("91 7038008002", true)]
        [DataRow("919652540074", false)]
        [DataRow("9144 9682565874", false)]
        [DataRow("91 1652598764", false)]
        public void GivenMobileNumberValidation(string mobileNumber, bool expected) // Testing for mobile number Validation
        {
            //Act
            bool actual = validation.MobileNumberValidation(mobileNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfghnkjghjbn", true)]
        [DataRow("ADF@#hjdfGB", true)]
        [DataRow("PRGkh", false)]
        [DataRow("7084", false)]
        public void GivenPasswordRule1Validation(string password, bool expected) // Testing for Password Rule - 1  Validation
        {
            //Act
            bool actual = validation.PasswordValidation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfghnjvbn", false)]
        [DataRow("A5sdf@#34", true)]
        [DataRow("FVGdf", false)]
        [DataRow("wsdfgADFG65@3", true)]
        public void GivenPasswordRule2Validation(string password, bool expected) // Testing for Password Rule - 2  Validation
        {
            //Act
            bool actual = validation.PasswordRule2Validation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfgDnjvbn", false)]
        [DataRow("A5sdf@df", true)]
        [DataRow("F5G@f", false)]
        [DataRow("85ADcv*gj5", true)]
        [DataRow("&&d", false)]
        [DataRow("885@dfvvvb", false)]
        [DataRow("AAaa#8ghbb", true)]
        public void PasswordRule3Validation(string password, bool expected) // Testing for Password Rule - 3 along with all rules Validation
        {
            //Act
            bool actual = validation.PasswordRule3Validation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfgDnjvbn", false)]
        [DataRow("A5sdf@df", true)]
        [DataRow("F5G@f", false)]
        [DataRow("85ADcv*gj5", true)]
        [DataRow("&&d", false)]
        [DataRow("885@dfvvvb", false)]
        [DataRow("AAaa#8ghbb", true)]
        public void PasswordRule4Validation(string password, bool expected) // Testing for Password Rule - 4 along with all rules Validation
        {
            //Act
            bool actual = validation.PasswordRule4Validation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        //Checking for multiple email samples that are valid
        [DataRow("abc@gmail.com", true)]
        [DataRow("abc-100@yahoo.com", true)]
        [DataRow("abc.100@yahoo.com", true)]
        [DataRow("abc@1.com", true)]
        [DataRow("abc111@yahoo.com.au", true)]
        [DataRow("abc-100@yahoo.com.au", true)]
        [DataRow("abc@gmail.com.com", true)]
        [DataRow("abc+100@yahoo.com", true)]
        //Checking for multiple email samples that are Invalid
        [DataRow("abc", false)]
        [DataRow("abc@.com.my", false)]
        [DataRow("abc123@gmail.a", false)]
        [DataRow("abc123@.com", false)]
        [DataRow("abc@.com.com", false)]
        [DataRow(".abc@abc.com", false)]
        [DataRow("abc()*@gmail.com", false)]
        [DataRow("abc@%*.com", false)]
        [DataRow("abc..2002@gmail.com", false)]
        [DataRow("abc.@gmail.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc@gmail.com.1a", false)]
        [DataRow("abc@gmail.com.aa.au", false)]
        public void GivenSampleEmailsValidation(string email, bool expected) // Testing for some email samples Validation
        {
            //Act
            bool actual = validation.EmailValidation(email);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
