using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationLamda;

namespace MSTestingUserRegistration
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        //Checking for multiple first name
        [DataRow("Praful", true)]
        [DataRow("pr", false)]
        [DataRow("praful", false)]
        [DataRow("Pr", false)]
        [DataRow("Pra", true)]
        public void GivenFirstNameValidation(string firstName, bool expected) // Testing for Firstname Validation
        {
            //Arrange
            SetValidation validation = new SetValidation();
            //Act
            bool actual = validation.FirstNameValidation(firstName);
            //Assert
            Assert.AreEqual(expected, actual);
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

    }
}
