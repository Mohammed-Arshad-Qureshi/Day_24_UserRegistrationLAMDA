using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationLamda
{
    class CustomException:Exception
    {
        public enum ExceptionType //Creating a enum with 3 variable
        {
            NULL_INPUT, EMPTY_INPUT, INVALID_INPUT
        }
        public ExceptionType type; // Creating enum name type variable
        public CustomException(ExceptionType type, string message) : base(message) // Creating a constructor with parent class
        {
            this.type = type;// Assigning value
        }
    }
}
