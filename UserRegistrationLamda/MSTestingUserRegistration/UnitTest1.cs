using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationLamda;

namespace MSTestingUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            //Checking for multiple first name
            [DataRow("Arshad", true)]
            [DataRow("ar", false)]
            [DataRow("arshad", false)]
            [DataRow("Ar", false)]
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
    }
}
