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
    }
}
