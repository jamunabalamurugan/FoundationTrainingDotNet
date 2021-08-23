using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingEg
{
    public class InvalidAgeException :ApplicationException
    {
        public InvalidAgeException(String message)
            : base(message)
        {

        }
    }
    class CustomException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validate(17);
            }
            catch (InvalidAgeException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.Read();
        }
    }
}
