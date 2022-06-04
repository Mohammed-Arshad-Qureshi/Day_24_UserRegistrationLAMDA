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
    }
}
